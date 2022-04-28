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





        [JsonProperty("country")]
        public string Country { get; private set; }

        [JsonProperty("fifa_code")]
        public string Code { get; private set; }

        [JsonProperty("goals_for")]
        public long Goals { get; private set; }



        

        public override string ToString() => $"{Country} ({Code})";
    }
}
