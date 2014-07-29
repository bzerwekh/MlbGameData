using Newtonsoft.Json;

namespace MlbData.Engine.MLB
{
    public class GameData
    {
        [JsonProperty("games", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Games Games { get; set; }
    }
}