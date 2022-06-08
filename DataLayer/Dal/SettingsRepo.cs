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








    public class SettingsRepo : IRepo<Settings>
    {
        public IList<Settings> Load(string Path)
        {
            try
            {
                string[] lines = File.ReadAllLines(Path);
                IList<Settings> list = new List<Settings>();
                lines.ToList().ForEach(l => list.Add(Settings.Parse(l)));
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Save(string Path, IList<Settings> settings)
        {
            try
            {
                File.WriteAllLines(Path, settings.Select(s => Settings.PrepareForFile(s)));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
