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
        private const string MaleMatchesPath = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        private const string MaleTeamsPath = "https://world-cup-json-2018.herokuapp.com/teams/results";
        private const string LocalMaleTeamsPath = @"..\..\..\DataLayer\Endpoints\men\teams.json";


        private const string FemaleMatchesPath = "http://worldcup.sfg.io/matches/country?fifa_code=";
        private const string FemaleTeamsPath = "http://worldcup.sfg.io/teams/results";
        private const string LocalFemaleTeamsPath = @"..\..\..\DataLayer\Endpoints\women\teams.json";


        private const string SettPath = @"..\..\..\DataLayer\Endpoints\settings.txt";
        private const string FavTeamPath = @"..\..\..\DataLayer\Endpoints\FavoriteTeam.txt";
        private const string FavPlayersPath = @"..\..\..\DataLayer\Endpoints\FavoritePlayers.txt";

        Settings sett = new Settings();
        Team favoriteTeam = new Team();
        //IList<Player> favoritePlayers = new List<Player>();
        IList<Player> players = new List<Player>();
        List<Match> matches;


        public static IList<Player> FavoritePlayers = new List<Player>();
        public static IList<Player> AllPlayers = new List<Player>();
        public static string SettingsPath => SettPath;

        public static string FavoriteTeamPath => FavTeamPath;

        public static string FavoritePlayersPath => FavPlayersPath;

        public IList<Player> GetAllPlayers(Team team)
        {
            matches = ApiLoader<Match>.GetApiDataSet($"{GetCorrectPath()[1]}{team.Code}");

            List<Player> homeTeam = matches[0].HomeTeamStatistics.StartingEleven;
            List<Player> awayTeam = matches[0].AwayTeamStatistics.StartingEleven;
            homeTeam.AddRange(matches[0].HomeTeamStatistics.Substitutes);
            awayTeam.AddRange(matches[0].AwayTeamStatistics.Substitutes);

            return matches[0].HomeTeam.CodeForCheck == team.Code ? homeTeam : awayTeam;

        }

        public void RemovePlayerFromFavorites(Player p)
        {
            for (int i = 0; i < FavoritePlayers.Count; i++)
            {
                if (FavoritePlayers.ElementAt(i).Name == p.Name)
                {
                    AllPlayers.Add(FavoritePlayers.ElementAt(i));
                    FavoritePlayers.RemoveAt(i);
                    //throw new Exception($"{AllPlayers.Count},,,{FavoritePlayers.Count}");
                    return;
                }
            }


        }
        
        
        public IList<Team> GetAllTeams()
        {


            return ApiLoader<Team>.GetApiDataSet(GetCorrectPath()[0]);


        }
        public Settings LoadSettings()
        {

            IRepo<Settings> repo = RepoFactory.GetSettRepo<Settings>();

            if (File.Exists(SettingsPath))
            {
                IList<Settings> settings = repo.Load(SettingsPath);

                sett = settings[0];

            }

            return sett;
        }
        public Team LoadFavoriteTeam()
        {

            IRepo<Team> repo = RepoFactory.GetTeamRepo<Team>();

            if (File.Exists(FavTeamPath))
            {
                IList<Team> teams = repo.Load(FavTeamPath);

                favoriteTeam = teams[0];

            }

            return favoriteTeam;
        }
        public void SaveSettings<T>(T model, string path)
        {
            IList<T> modelList = new List<T>() { model };
            IRepo<T> repo = RepoFactory.GetSettRepo<T>();

            repo.Save(path, modelList);
        }
        public void SaveTeam<T>(T model, string path)
        {
            IList<T> modelList = new List<T>() { model };
            IRepo<T> repo = RepoFactory.GetTeamRepo<T>();

            repo.Save(path, modelList);
        }
        private string[] GetCorrectPath()
        {
            string[] path = new string[2];
            LoadSettings();

            if (IsConnectedToInternet())
            {
                switch (sett.TeamsGender)
                {
                    case Gender.Male:
                        path[0] = MaleTeamsPath;
                        path[1] = MaleMatchesPath;
                        break;
                    case Gender.Female:
                        path[0] = FemaleTeamsPath;
                        path[1] = FemaleMatchesPath;
                        break;
                    default:
                        path[0] = LocalMaleTeamsPath;
                        path[1] = MaleMatchesPath;
                        break;
                }
                return path;
            }
            else
            {
                switch (sett.TeamsGender)
                {
                    case Gender.Male:
                        path[0] = LocalMaleTeamsPath;
                        break;
                    case Gender.Female:
                        path[0] = LocalFemaleTeamsPath;
                        break;
                    default:
                        path[0] = LocalMaleTeamsPath;
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

        public bool AddPlayerToFavorites(Player p)
        {
            if (FavoritePlayers.Count > 2)
            {
                //throw new Exception($"Preko 3 igraca, ima ih:{FavoritePlayers.Count}");
                return false;
            }
            p.IsFavorite = true;
            FavoritePlayers.Add(p);
            foreach (var pl in AllPlayers)
            {
                if (pl.Name == p.Name)
                {
                    bool test = AllPlayers.Remove(pl);
                    //throw new Exception($"{AllPlayers.Count},,,,{FavoritePlayers.Count}");
                    break;
                }
            }

            return true;

        }
        public void SaveFavoritePlayers<T>(List<T> model, string path)
        {
            IList<T> modelList = model;
            IRepo<T> repo = RepoFactory.GetPlayerRepo<T>();

            repo.Save(path, modelList);
        }

        public IList<Player> LoadFavoritePlayers()
        {

            IRepo<Player> repo = RepoFactory.GetPlayerRepo<Player>();

            if (File.Exists(FavPlayersPath))
            {
                IList<Player> models = repo.Load(FavPlayersPath);

                 FavoritePlayers = models;

            }

            return FavoritePlayers;
        }
    }
}
