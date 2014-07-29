using System.Runtime.Serialization;
using GetGameScoreForTeam.DataContracts;

namespace GetGameScoreForTeam
{
    [DataContract]
    public class Result : IResult
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