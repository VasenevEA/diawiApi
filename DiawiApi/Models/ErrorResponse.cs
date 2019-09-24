using Newtonsoft.Json;

namespace DiawiApi.Models
{
    public class ErrorResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
