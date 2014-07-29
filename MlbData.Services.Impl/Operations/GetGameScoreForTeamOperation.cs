using System;
using System.Collections.Generic;
using System.Linq;
using MlbData.Engine.Tasks;
using MlbData.Services.DataContracts;
using MlbData.Services.DataContracts.Interfaces;
using MlbData.Services.Impl.Interfaces;

namespace MlbData.Services.Impl.Operations
{
    public class GetGameScoreForTeamOperation : IOperation
    {
        public IGameScoreServiceResponse Execute(IGameScoreServiceRequest request)
        {
            var getGameRequest = request as GetGameScoreRequest;
            var response = new GetGameScoreResponse();

            var task = new FetchMlbDataTask(request.Date);
            if (task.Process())
            {
                var gameResults = new List<GameResult>();
                var game =
                    task.GetResults().Data.Games.Game.First(
                        x => x.HomeTeamName == getGameRequest.TeamName || x.AwayTeamName == getGameRequest.TeamName);
                gameResults.Add(new GameResult
                                    {
                                        HomeTeam = game.HomeTeamName,
                                        AwayTeam = game.AwayTeamName,
                                        HomeRuns = Convert.ToInt32(game.Linescore.Runs.Homeruns),
                                        AwayRuns = Convert.ToInt32(game.Linescore.Runs.Awayruns)
                                    });
                response.GameResults = gameResults;
                response.Successful = true;
            }
            else
            {
                response.Successful = false;
                response.Message = "Something Failed in Process";
            }

            return response;
        }
    }
}