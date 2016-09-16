using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TokenExWebDemo.DTO;
using TokenExWebDemo.Models;

namespace TokenExWebDemo.Controllers
{
    public class IframeController : Controller
    {
       

        // GET: Iframe
        public ActionResult Index()
        {
            string origin = Request.Url.Scheme + "://" + Request.Url.Authority;

            string SessionURL = GetSessionURL(origin, "YourOwnReferenceNumber");
            ViewBag.SessionURL = SessionURL;
            return View( new IframeViewModel());
        }
        



        [HttpPost]
        public ActionResult Index(IframeViewModel model)
        {
            if (!ModelState.IsValid) //Check for validation errors
            {
                return View(model);
            }

            //validate our HMAC

            string localHMAC = GenerateHMAC(model.IframeData, Config.HTPHMACKey);
            if (localHMAC.Equals(model.HMAC))
            {
                ViewBag.token = model.Token;
                return View(new IframeViewModel());
            }
            else
            {
                //handel invalid HMAC
                return View(new IframeViewModel());
            }
        }

        /// <summary>
        /// valid HMAC siganture to detect modifications from the browser
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="HMACKey"></param>
        /// <returns></returns>
        private string GenerateHMAC(string payload, string HMACKey)
        {
            string result = string.Empty;

            System.Security.Cryptography.HMACSHA256 hmac = new System.Security.Cryptography.HMACSHA256();
            hmac.Key = System.Text.Encoding.UTF8.GetBytes(HMACKey);
            var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(payload));
            result = Convert.ToBase64String(hash);
            return result;
        }

        /// <summary>
        /// Post's JSON payload to TokenEx to obtain the single use session URL
        /// http://docs.tokenex.com/#hosted-tokenization-page-iframe-create-a-single-use-session
        /// </summary>
        /// <param name="originurl"></param>
        /// <param name="refnumber"></param>
        /// <returns></returns>
        private static string GetSessionURL(string originurl, string refnumber)
        {
            SessionRequest req = new SessionRequest();
            req.TokenExID = Config.TokenExID;
            req.APIKey = Config.APIKey; 
            req.HMACKey = Config.HTPHMACKey;
            req.TokenScheme = Config.TokenScheme;
            req.OriginURL = originurl;
            req.CustomerRefnumber = refnumber;
            req.CSS = Config.HTPCSS;


            try
            {
                SessionResponse result = new SessionResponse();
                using (HttpClient client = new HttpClient())
                {
                    var HTTPresult = client.PostAsJsonAsync<SessionRequest>(Config.HTPURL, req).Result;

                    result = HTTPresult.Content.ReadAsAsync<SessionResponse>().Result;

                }

                if (result.Success)
                {
                    return result.HTPURL;
                }
                else
                {
                    return result.Error;

                }
            }
            catch (Exception ex)
            {
                return $"An error occurred:  {ex.Message} ";
            }
        }

    }
}