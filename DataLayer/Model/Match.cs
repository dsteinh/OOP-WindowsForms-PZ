using Newtonsoft.Json;
using System;

namespace DataLayer.Model
{
    public class Match
    {


        [JsonProperty("venue")]
        public string Venue { get; private set; }

        [JsonProperty("location")]
        public string Location { get; private set; }

        [JsonProperty("attendance")]
        public long Attendance { get; private set; }

        [JsonProperty("home_team")]
        public Team HomeTeam { get; private set; }

        [JsonProperty("away_team")]
        public Team AwayTeam { get; private set; }

        [JsonProperty("home_team_statistics")]
        public TeamStatistics HomeTeamStatistics { get; private set; }

        [JsonProperty("away_team_statistics")]
        public TeamStatistics AwayTeamStatistics { get; private set; }

        public override string ToString() => $"{Venue}: \n{HomeTeamStatistics}";
    }
}