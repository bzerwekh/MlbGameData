using System.Collections.Generic;
using Newtonsoft.Json;

namespace MlbData.Engine.MLB
{
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
}