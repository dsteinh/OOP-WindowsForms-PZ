using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dal
{
    internal class PlayerRepo : IRepo<Player>
    {
        public IList<Player> Load(string Path)
        {
            try
            {
                string[] lines = File.ReadAllLines(Path);
                IList<Player> list = new List<Player>();
                lines.ToList().ForEach(l => list.Add(Player.Parse(l)));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save(string Path, IList<Player> data)
        {
            try
            {
                File.WriteAllLines(Path, data.Select(s => Player.PrepareForFile(s)));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
