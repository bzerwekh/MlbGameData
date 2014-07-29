using System;
using GetGameScoreForTeam.MLB;
using GetGameScoreForTeam.Service;
using GetGameScoreForTeam.Tasks;

namespace GetGameScoreForTeam
{
    public class GetGameResultForTeam : IGetGameResultForTeam
    {
        public Result GetGameResult(string team, DateTime date)
        {
            Result result = null;
            var task = new GameDataForDateTask(date);
            if (task.Process())
            {
                result = ProcessForTeam(team, task.GetResults());
            }

            return result ?? new Result();
        }

        private Result ProcessForTeam(string team, MLBData mlbData)
        {
            var result = new Result();
            foreach (var game in mlbData.Data.Games.Game)
            {
                if (game.HomeTeamName == team || game.AwayTeamName == team)
                {
                    result = new Result
                                 {
                                     HomeTeam = game.HomeTeamName,
                                     AwayTeam = game.AwayTeamName,
                                     HomeRuns = Convert.ToInt32(game.Linescore.Runs.Homeruns),
                                     AwayRuns = Convert.ToInt32(game.Linescore.Runs.Awayruns)
                                 };
                }
            }

            return result;
        }
    }
}
