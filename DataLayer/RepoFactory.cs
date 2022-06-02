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
        public static IRepo<T> GetRepo<T>() => (IRepo<T>) new FileRepo();
        
    }
}
