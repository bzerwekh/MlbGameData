using Newtonsoft.Json;

namespace MlbData.Engine.MLB
{
    public class Game
    {
        [JsonProperty("home_team_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string HomeTeamName { get; set; }

        [JsonProperty("away_team_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AwayTeamName { get; set; }

        [JsonProperty("linescore", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Linescore Linescore { get; set; }  
    }
}
