using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dal
{
    internal class FileRepo : IRepo
    {
        public IList<Player> Load(string Path)
        {
            throw new NotImplementedException();
        }

        public void Save(string Path, IList<Player> players)
        {
            throw new NotImplementedException();
        }
    }
}
