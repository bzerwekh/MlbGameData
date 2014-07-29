using System.Runtime.Serialization;

namespace GetGameScoreForTeam.DataContracts
{
    public interface IResult
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