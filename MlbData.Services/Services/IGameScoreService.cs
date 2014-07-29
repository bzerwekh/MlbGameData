using System.ServiceModel;
using MlbData.Services.DataContracts;

namespace MlbData.Services.Services
{
    [ServiceContract]
    public interface IGameScoreService
    {
        [OperationContract]
        GetGameScoreResponse GetGameScoreForTeam(GetGameScoreRequest request);

        [OperationContract]
        GetGameScoreResponse GetGameScoresForDate(GetGameScoresForDateRequest request);
    }
}
