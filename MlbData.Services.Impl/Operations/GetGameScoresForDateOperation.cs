using MlbData.Services.DataContracts;
using MlbData.Services.DataContracts.Interfaces;
using MlbData.Services.Impl.Interfaces;

namespace MlbData.Services.Impl.Operations
{
    public class GetGameScoresForDateOperation : IOperation
    {
        public IGameScoreServiceResponse Execute(IGameScoreServiceRequest request)
        {
            var response = new GetGameScoreResponse();

            return response;
        }
    }
}