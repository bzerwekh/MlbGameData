using System.Collections.Generic;
using System.Runtime.Serialization;
using MlbData.Services.DataContracts.Interfaces;

namespace MlbData.Services.DataContracts
{
    [DataContract]
    public class GetGameScoreResponse : IGameScoreServiceResponse
    {
        [DataMember]
        public IEnumerable<GameResult> GameResults { get; set; }

        [DataMember]
        public bool Successful { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}