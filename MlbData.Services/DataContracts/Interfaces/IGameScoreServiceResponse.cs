using System.Runtime.Serialization;

namespace MlbData.Services.DataContracts.Interfaces
{
    public interface IGameScoreServiceResponse
    {
        bool Successful { get; set; }
        string Message { get; set; }
    }
}