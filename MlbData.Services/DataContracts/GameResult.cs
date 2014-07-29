using System.Runtime.Serialization;
using MlbData.Services.DataContracts.Interfaces;

namespace MlbData.Services.DataContracts
{
    [DataContract]
    public class GameResult : IGameResult
    {
        [DataMember]
        public string HomeTeam { get; set; }

        [DataMember]
        public string AwayTeam { get; set; }

        [DataMember]
        public int HomeRuns { get; set; }

        [DataMember]
        public int AwayRuns { get; set; }
    }
}
