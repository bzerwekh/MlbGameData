using System;
using System.Runtime.Serialization;
using MlbData.Services.DataContracts.Interfaces;

namespace MlbData.Services.DataContracts
{
    [DataContract]
    public class GetGameScoreRequest : IGameScoreServiceRequest
    {
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public string TeamName { get; set; }
    }
}
