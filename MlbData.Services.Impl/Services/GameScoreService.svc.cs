using MlbData.Services.DataContracts;
using MlbData.Services.Impl.Operations;
using MlbData.Services.Services;

namespace MlbData.Services.Impl.Services
{
    public class GameScoreService : IGameScoreService
    {
        public GetGameScoreResponse GetGameScoreForTeam(GetGameScoreRequest request)
        {
            var operation = new GetGameScoreForTeamOperation();
            return operation.Execute(request) as GetGameScoreResponse;
        }

        public GetGameScoreResponse GetGameScoresForDate(GetGameScoresForDateRequest request)
        {
            var operation = new GetGameScoresForDateOperation();
            return operation.Execute(request) as GetGameScoreResponse;
        }
    }
}
