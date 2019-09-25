using Newtonsoft.Json;

namespace DiawiApi.Models
{
    public class Response
    {
        [JsonProperty("status")]
        public StatusCode Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
