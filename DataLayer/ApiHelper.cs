using DataLayer.Dal;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{

    public class ApiHelper
    {
        private const string MatchesPath = "https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string TeamsPath = "https://world-cup-json-2018.herokuapp.com/teams/results";

        public IList<Player> GetAllPlayers(Team team)
        {
            List<Match> matches = ApiLoader<Match>.GetApiDataSet($"{MatchesPath}{team.Code}");

            if (team.Code == matches[0].HomeTeam.Code)
            {
                return matches[0].HomeTeamStatistics.StartingEleven;
            }
            else
            {
                return matches[0].AwayTeamStatistics.StartingEleven;
            }


            

        }

        public IList<Team> GetAllTeams()
        {

            return ApiLoader<Team>.GetApiDataSet(TeamsPath);

        }


    }
}
