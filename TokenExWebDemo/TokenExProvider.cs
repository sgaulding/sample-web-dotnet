using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;


namespace TokenExWebDemo
{
    public class TokenExAPIProvider
    {

        private HttpResponseMessage MakeAPICall<T>(object dto, string url)
        {
            HttpResponseMessage result = new HttpResponseMessage();

            try
            {
                using (HttpClient client = new HttpClient())
                {

                    result = client.PostAsJsonAsync<T>(url, (T)dto).Result;

                }
                if (!result.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"oops {result.StatusCode.ToString()}");

                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }
}