using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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

        [JsonProperty("home_team_events")]
        public List<TeamEvent> HomeTeamEvents { get; set; }

        [JsonProperty("away_team_events")]
        public List<TeamEvent> AwayTeamEvents { get; set; }

        [JsonProperty("winner")]
        public string Winner { get; set; }

        [JsonProperty("winner_code")]
        public string WinnerCode { get; set; }

        public override string ToString() => $"{Venue}: \n{HomeTeamStatistics}";
    }
}