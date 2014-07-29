using Newtonsoft.Json;

namespace MlbData.Engine.MLB
{
    public class MLBData
    {
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Subject { get; set; }

        [JsonProperty("copyright", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Copyright { get; set; }

        [JsonProperty("data")]
        public GameData Data { get; set; }
    }
}