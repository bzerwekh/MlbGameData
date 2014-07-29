using System;
using System.ServiceModel;

namespace GetGameScoreForTeam.Service
{
    [ServiceContract]
    public interface IGetGameResultForTeam
    {
        [OperationContract]
        Result GetGameResult(string team, DateTime date);
    }
}
