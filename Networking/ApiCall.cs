using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;


/*
 * This class is made with heavy inspiration from: https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient
 * Oficial documentation
 * This client is super general and returns a JSON string response 
 */
namespace DNDHelper.Networking
{
    public class ApiCall
    {

        private static readonly HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://www.dnd5eapi.co/"),
        };
        public static async Task<string> GetAsync(string subPath)
        {
            using HttpResponseMessage response= await sharedClient.GetAsync(subPath);

            response.EnsureSuccessStatusCode();
            string jsonResponse= await response.Content.ReadAsStringAsync();
            return jsonResponse;
        }



    }
  
}
