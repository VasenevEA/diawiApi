using Newtonsoft.Json;
using System;

namespace DiawiApi.Models
{
    public class Response
    {
        [JsonProperty("status")]
        public StatusCode Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("links")]
        public Uri[] Links { get; set; }

        [JsonProperty("qrcodes")]
        public Uri[] Qrcodes { get; set; }
    }
}
