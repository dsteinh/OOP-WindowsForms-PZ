using DataLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dal
{


    public static class ApiLoader<T>
    {
        private static IList<T> list = new List<T>();

        public static List<T> GetApiDataSet(string path)
        {


            string json = new WebClient().DownloadString(path);
            list = JsonConvert.DeserializeObject<List<T>>(json);



            return new List<T>(list);
        }


    }
}
