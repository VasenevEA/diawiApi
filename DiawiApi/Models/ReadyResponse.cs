using Newtonsoft.Json;

namespace DiawiApi.Models
{
    public class ReadyResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("hash")]
        public string Hash { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
