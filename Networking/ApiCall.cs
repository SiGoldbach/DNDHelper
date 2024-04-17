using DNDHelper.Models.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

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

        public static async Task<T> GetAndDeserilize<T>(string subpath)
        {
            try
            {
                string jsonResponse = await GetAsync(subpath);
                T? TempMonsters = JsonSerializer.Deserialize<T>(jsonResponse, options);
                if (TempMonsters != null)
                {
                    return TempMonsters;
                }
                else
                {
                    throw new Exception("");

                }
            }catch (JsonException ex)
            {
                throw new Exception(ex.Message);
            }catch (TypeLoadException ex) {
                throw new Exception(ex.Message);
            }catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
                
            }
         



        }



    }
  
}
