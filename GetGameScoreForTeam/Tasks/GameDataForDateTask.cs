using System;
using System.Net;
using GetGameScoreForTeam.MLB;
using Newtonsoft.Json;

namespace GetGameScoreForTeam.Tasks
{
    public class GameDataForDateTask
    {
        private string _requestDate;
        private MLBData _data;

        public GameDataForDateTask(DateTime date)
        {
            _requestDate = string.Format("year_{0}/month_{1}/day_{2}", date.ToString("yyyy"), date.ToString("MM"), date.ToString("dd"));
        }

        public MLBData GetResults()
        {
            return _data;
        }

        public bool Process()
        {
            string mlbJson;
            var gameDataUri = new Uri(string.Format("http://gd2.mlb.com/components/game/mlb/{0}/master_scoreboard.json", _requestDate));
            using (var client = new WebClient())
            {
                mlbJson = client.DownloadString(gameDataUri);
            }

            try
            {
                _data = JsonConvert.DeserializeObject<MLBData>(mlbJson);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}