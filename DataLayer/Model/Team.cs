using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Team
    {

        private const char Del = ';';




        [JsonProperty("country")]
        public string Country { get; private set; }

        [JsonProperty("fifa_code")]
        public string Code { get; private set; }

        [JsonProperty("goals_for")]
        public long Goals { get; private set; }

        [JsonProperty("code")]
        public string CodeForCheck { get; private set; }




        public override string ToString() => $"{Country} ({Code})";

        internal static Team Parse(string s)
        {
            try
            {
                string[] details = s.Split(Del);
                


                return new Team
                {
                    Country = details[0],
                    Code = details[1],
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static string PrepareForFile(Team s) => $"{s.Country}{Del}{s.Code}";

    }
}
