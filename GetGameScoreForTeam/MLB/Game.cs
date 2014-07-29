using System.Collections.Generic;
using Newtonsoft.Json;

namespace GetGameScoreForTeam.MLB
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

    public class GameData
    {
        [JsonProperty("games", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Games Games { get; set; }
    }

    public class Games
    {
        [JsonProperty("next_day_date")]
        public string NextDayDate { get; set; }

        [JsonProperty("modified_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        [JsonProperty("month", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Month { get; set; }

        [JsonProperty("year", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Year { get; set; }

        [JsonProperty("day", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Day { get; set; }

        [JsonProperty("game", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IList<Game> Game { get; set; }

    }

    public class Game
    {
        [JsonProperty("home_team_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string HomeTeamName { get; set; }

        [JsonProperty("away_team_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AwayTeamName { get; set; }

        [JsonProperty("linescore", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Linescore Linescore { get; set; }  
    }

    public class Linescore
    {
        [JsonProperty("r", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Runs Runs { get; set; }
    }

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
