using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using iBakePancakes.Models;
using Newtonsoft.Json;

namespace iBakePancakes
{
    public static class PancakeService
    {
        static HttpClient httpClient;
        static List<Pancake> pancakes;

        public static async Task<List<Pancake>> GetPancakes()
        {
            if (pancakes != null)
                return pancakes;

            if (httpClient == null)
            {
                httpClient = new HttpClient();
            }

            var result = await httpClient.GetAsync("https://www.thewissen.io/pancakes.json");
            var resultAsString = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Pancake>>(resultAsString);
        }
    }
}
