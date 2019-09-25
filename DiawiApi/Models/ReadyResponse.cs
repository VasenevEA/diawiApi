using Newtonsoft.Json;

namespace DiawiApi.Models
{
    public class ReadyResponse : Response
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
