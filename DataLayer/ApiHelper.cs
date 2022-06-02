using DataLayer.Dal;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{

    public class ApiHelper
    {
        private const string MaleMatchesPath = "https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string MaleTeamsPath = "https://world-cup-json-2018.herokuapp.com/teams/results";
        private const string LocalMaleTeamsPath = @"..\..\..\DataLayer\Endpoints\men\teams.json";


        private const string FemaleTeamsPath = "http://worldcup.sfg.io/teams/results";
        private const string LocalFemaleTeamsPath = @"..\..\..\DataLayer\Endpoints\women\teams.json";
        private const string SettPath = @"..\..\..\DataLayer\Endpoints\settings.txt";
        private const string FavPath = @"..\..\..\DataLayer\Endpoints\FavoriteTeam.txt";


        Settings sett = new Settings();

        public static string SettingsPath => SettPath;

        public static string FavoritePath1 => FavPath;

        public IList<Player> GetAllPlayers(Team team)
        {
            List<Match> matches = ApiLoader<Match>.GetApiDataSet($"{MaleMatchesPath}{team.Code}");

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


            return ApiLoader<Team>.GetApiDataSet(GetCorrectPath());


        }
        public Settings LoadSettings()
        {
            
            IRepo<Settings> repo = RepoFactory.GetRepo<Settings>();

            if (File.Exists(SettingsPath))
            {
                IList<Settings> settings = repo.Load(SettingsPath);
                
                sett = settings[0];

            }
           
            return sett;
        }
        public void SaveModel<T>(T model, string path)
        {
            IList<T> modelList = new List<T>() { model };
            IRepo<T> repo = RepoFactory.GetRepo<T>();
            repo.Save(path, modelList);
        }
        private string GetCorrectPath()
        {
            string path;
            LoadSettings();

            if (IsConnectedToInternet())
            {
                switch (sett.TeamsGender)
                {
                    case Gender.Male:
                        path = MaleTeamsPath;
                        break;
                    case Gender.Female:
                        path = FemaleTeamsPath;
                        break;
                    default:
                        path = LocalMaleTeamsPath;
                        break;
                }
                return path;
            }
            else
            {
                switch (sett.TeamsGender)
                {
                    case Gender.Male:
                        path = LocalMaleTeamsPath;
                        break;
                    case Gender.Female:
                        path = LocalFemaleTeamsPath;
                        break;
                    default:
                        path = LocalMaleTeamsPath;
                        break;
                }
                return path;
            }
        }

        public bool IsConnectedToInternet()
        {
            string host = "www.google.com";
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch
            {
                return result;   
            }
            return result;
        }
    }
}
