using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public enum Gender
    {
        Male,
        Female
    }
    public enum Language
    {
        CRO,
        ENG
    }
    public class Settings
    {
        private const char Del = ';';
        public Gender TeamsGender { get; set; }
        public Language AppLanguage { get; set; }

        
        public static string PrepareForFile(Settings s) => $"{s.TeamsGender}{Del}{s.AppLanguage}";
        public static Settings Parse(string s)
        {
            try
            {
                string[] details = s.Split(Del);
                Enum.TryParse(details[0], out Gender TeamsGender);
                Enum.TryParse(details[1], out Language AppLanguage);

                
                return new Settings
                {
                    TeamsGender = TeamsGender,
                    AppLanguage = AppLanguage
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override string ToString() => $"{TeamsGender}{Del}{AppLanguage}";

        
    }
}
