using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
    public class TeamStatistics
    {
        [JsonProperty("starting_eleven")]
        public List<Player> StartingEleven { get; private set; }

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