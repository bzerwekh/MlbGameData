using System.Runtime.Serialization;

namespace MlbData.Services.DataContracts.Interfaces
{
    public interface IGameResult
    {
        [DataMember]
        string HomeTeam { get; set; }

        [DataMember]
        string AwayTeam { get; set; }

        [DataMember]
        int HomeRuns { get; set; }

        [DataMember]
        int AwayRuns { get; set; }
    }
}
