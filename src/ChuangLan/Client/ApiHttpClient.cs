using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChuangLan.Client
{
    internal class ApiHttpClient
    {
        private static readonly HttpClient HttpClient;

        static ApiHttpClient()
        {
            HttpClient = new HttpClient();
        }

        internal static async Task<TResult> PostAsync<TResult>(string url, string jsonData) where TResult : class
        {
            var response = await HttpClient.PostAsync(url, new StringContent(jsonData, Encoding.UTF8, "application/json"));
            return JsonConvert.DeserializeObject<TResult>(await response.Content.ReadAsStringAsync());
        }

        internal static TResult Post<TResult>(string url, string jsonData) where TResult : class
        {
            var response = AsyncHelper.RunSync(() =>
                 HttpClient.PostAsync(url, new StringContent(jsonData, Encoding.UTF8, "application/json")));

            return JsonConvert.DeserializeObject<TResult>(AsyncHelper.RunSync(() => response.Content.ReadAsStringAsync()));
        }
    }
}
