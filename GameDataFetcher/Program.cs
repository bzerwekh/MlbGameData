using System;
using System.Net;
using GameDataFetcher.MLB;
using Newtonsoft.Json;

namespace GameDataFetcher
{
    class Program
    {
        private static string _data;
        private static bool _processing = true;

        static void Main(string[] args)
        {
            _data = null;
            GetGameData();
        }

        private static void GetGameData()
        {
            var gameDataUri = new Uri("http://gd2.mlb.com/components/game/mlb/year_2014/month_07/day_26/master_scoreboard.json");
            using (var client = new WebClient())
            {
                client.DownloadStringCompleted += DownloadMlbDataComplete;
                client.DownloadStringAsync(gameDataUri);
                
                while (_processing)
                {
                    
                }
            }
        }

        private static void DownloadMlbDataComplete(object sender, DownloadStringCompletedEventArgs e)
        {
            _data = e.Result;
            MLBData mlbData;
            try
            {
                mlbData = JsonConvert.DeserializeObject<MLBData>(_data);
                //mlbData = JsonConvert.DeserializeObject<MLBData>(_data, new JsonSerializerSettings{MissingMemberHandling = MissingMemberHandling.Ignore});
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }         
            finally
            {
                _processing = false;
            }
        }
    }
}
