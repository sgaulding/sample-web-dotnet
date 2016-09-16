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
    public class BBEController : Controller
    {

        // GET: BBE
        public ActionResult Index()
        {
            return View(new BBEViewModel());
        }

        [HttpPost]
        public ActionResult Index(BBEViewModel model)
        {
            if (!ModelState.IsValid) //Check for validation errors
            {
                return View(model);
            }

            string tokeResponse = Tokenize(model.CipherText);
            ViewBag.token = tokeResponse;
            return View(new BBEViewModel());
        }
        /// <summary>
        /// send the cipher text to TokenEx to Obtain a token. 
        /// http://docs.tokenex.com/#tokenex-api-token-services-tokenizefromencryptedvalue
        /// </summary>
        /// <param name="ciperText"></param>
        /// <returns></returns>
        static string Tokenize(string ciperText)
        {
            TokenizeRequest req = new TokenizeRequest();
            req.TokenExID = Config.TokenExID;
            req.APIKey = Config.APIKey;
            req.EcryptedData = ciperText;
            req.TokenScheme = Config.TokenScheme;

            try
            {
                TokenizeResponse result = new TokenizeResponse();
                using (HttpClient client = new HttpClient())
                {
                    var HTTPresult = client.PostAsJsonAsync<TokenizeRequest>(Config.BBEURL, req).Result;

                    result = HTTPresult.Content.ReadAsAsync<TokenizeResponse>().Result;

                }

                if (result.Success)
                {
                    return result.Token;
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