using Newtonsoft.Json;

namespace MlbData.Engine.MLB
{
    public class Runs
    {
        [JsonProperty("home", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Homeruns { get; set; }
        
        [JsonProperty("away", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Awayruns { get; set; }
        
        [JsonProperty("diff", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Difference { get; set; }
    }
}