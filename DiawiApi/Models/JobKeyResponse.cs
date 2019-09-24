using Newtonsoft.Json;

namespace DiawiApi.Models
{
    public class JobKeyResponse
    {
        [JsonProperty("job")]
        public string JobKey { get; set; }
    }
}
