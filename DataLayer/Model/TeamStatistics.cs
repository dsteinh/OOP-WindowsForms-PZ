using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
    public class TeamStatistics
    {


        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("attempts_on_goal")]
        public long AttemptsOnGoal { get; set; }

        [JsonProperty("on_target")]
        public long OnTarget { get; set; }

        [JsonProperty("off_target")]
        public long OffTarget { get; set; }

        [JsonProperty("blocked")]
        public long Blocked { get; set; }

        [JsonProperty("corners")]
        public long Corners { get; set; }

        [JsonProperty("offsides")]
        public long Offsides { get; set; }

        [JsonProperty("ball_possession")]
        public long BallPossession { get; set; }

        [JsonProperty("pass_accuracy")]
        public long PassAccuracy { get; set; }

        [JsonProperty("num_passes")]
        public long NumPasses { get; set; }

        [JsonProperty("passes_completed")]
        public long PassesCompleted { get; set; }

        [JsonProperty("distance_covered")]
        public long DistanceCovered { get; set; }

        [JsonProperty("tackles")]
        public long Tackles { get; set; }


        [JsonProperty("starting_eleven")]
        public List<Player> StartingEleven { get; set; }

        [JsonProperty("substitutes")]
        public List<Player> Substitutes { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in StartingEleven)
            {
                sb.AppendLine(item.ToString());

            }
            return sb.ToString();
        }
    }
}