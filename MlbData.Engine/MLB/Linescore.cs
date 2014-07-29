using Newtonsoft.Json;

namespace MlbData.Engine.MLB
{
    public class Linescore
    {
        [JsonProperty("r", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Runs Runs { get; set; }
    }
}