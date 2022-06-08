using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public enum Position { Defender, Forward, Goalie, Midfield };



    public class Player
    {
        private const char Del = ';';

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public string ShirtNumber { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        public bool IsFavorite { get; set; }



        public override string ToString() => $"({Name}, Kapetan: {Captain}, NO. {ShirtNumber}, Pos. {Position})";

        internal static Player Parse(string l)
        {
            try
            {
                string[] details = l.Split(Del);
                bool.TryParse(details[1], out bool IsCapetan);
                bool.TryParse(details[3], out bool Favorite);

                return new Player
                {
                    Name = details[0],
                    Captain = IsCapetan,
                    ShirtNumber = details[2],
                    IsFavorite = Favorite,
                    Position = ToPosition(details[4])

                };

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        internal static string PrepareForFile(Player s) 
            => $"{s.Name}{Del}{s.Captain}{Del}{s.ShirtNumber}{Del}{s.IsFavorite}{Del}{s.Position}";

        public static Position ToPosition(string position)
        {
            Enum.TryParse(position, out Position pos);
            return pos;
        }
    }
}
