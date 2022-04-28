using DataLayer;
using DataLayer.Dal;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKijent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApiHelper ah = new ApiHelper();
            // List<Team> teams = ApiLoader<Team>.GetApiDataSet("https://world-cup-json-2018.herokuapp.com/teams/results");
            // teams.ForEach(Console.WriteLine);

            List<Match> matches = ApiLoader<Match>.GetApiDataSet("https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=CRO");


            List<Player> startingEleven = matches[0].HomeTeam.HomeTeamStatistics.StartingEleven;
            startingEleven.ForEach(p => Console.WriteLine(p));
            //matches.ForEach(Console.WriteLine);
            //matches.ForEach(p => p.HomeTeamStatistics.StartingEleven.ForEach(Console.WriteLine));


        }
    }
}
