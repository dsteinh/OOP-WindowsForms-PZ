using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public enum Position {NoData, Defender, Forward, Goalie, Midfield };


    
    public class Player
    {
        
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("captain")]
        public bool Captain { get; private set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; private set; }

        [JsonProperty("position")]
        public Position Position { get; private set;}

        


        public override string ToString() => $"({Name}, Kapetan: {Captain}, NO. {ShirtNumber}, Pos. {Position})";
    }
}
