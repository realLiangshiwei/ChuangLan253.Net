using Newtonsoft.Json;

namespace ChuangLan.Client.ApiRequest
{
    public class ApiPullMo
    {
        [JsonProperty]
        internal string Account { get; set; }

        [JsonProperty]
        internal string Password { get; set; }
        public ApiPullMo()
        {
            Count = 20;
        }

        public int Count { get; set; }
    }
}
