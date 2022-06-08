using DataLayer.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class RepoFactory 
    {
        public static IRepo<T> GetSettRepo<T>() => (IRepo<T>) new SettingsRepo();
        public static IRepo<T> GetTeamRepo<T>() => (IRepo<T>) new TeamRepo();

        public static IRepo<T> GetPlayerRepo<T>() => (IRepo<T>) new PlayerRepo();
    }
}
