using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dal
{
    //Ideja : napravi IFileable
    //Postavi sve sto zelis da se sprema sprema i loada da je IFileable
    //U taj interface stavi Parse i PrepareForFile metode
    //Napravi da FileRepo radi sa IFileableima








    public class TeamRepo : IRepo<Team>
    {
        public IList<Team> Load(string Path)
        {
            try
            {
                string[] lines = File.ReadAllLines(Path);
                IList<Team> list = new List<Team>();
                lines.ToList().ForEach(l => list.Add(Team.Parse(l)));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Save(string Path, IList<Team> teams)
        {
            try
            {
                File.WriteAllLines(Path, teams.Select(s => Team.PrepareForFile(s)));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
