using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dal
{
    public interface IRepo
    {
        IList<Player> Load(string Path);
        void Save(string Path, IList<Player> players);
    }
}
