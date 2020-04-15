using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPIApp
{
    public class MovieDataManager
    {
        const string Url = "https://itunes.apple.com/us/rss/topmovies/limit=25/json";



        private HttpClient GetClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            return httpClient;
        }

        public async Task<Feed> GetFeed()
        {
            return JsonConvert.DeserializeObject<Movie>(await GetClient().GetStringAsync(Url)).feed;
        }
    }
}
