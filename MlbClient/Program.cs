using System;

namespace MlbClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new GameResultService.GetGameResultForTeamClient();
            //var result = client.GetGameResult("Cubs", DateTime.Now);
            var request = new ServiceReference1.GetGameScoreRequest();
            request.Date = DateTime.Now.AddDays(-2);
            request.TeamName = "Cubs";
            var client = new ServiceReference1.GameScoreServiceClient();
            var result = client.GetGameScoreForTeam(request);
        }
    }
}
