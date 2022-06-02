using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dal
{
    public interface IRepo<T>
    {
        IList<T> Load(string Path);
        void Save(string Path, IList<T> data);
    }
}
