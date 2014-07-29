using MlbData.Services.DataContracts.Interfaces;

namespace MlbData.Services.Impl.Interfaces
{
    public interface IOperation
    {
        IGameScoreServiceResponse Execute(IGameScoreServiceRequest request);
    }
}