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
    public enum Resolution
    {
        Fullscreen,
        FHD,
        VGA
        
    }

    public class Settings
    {
        private const char Del = ';';
        public Gender TeamsGender { get; set; }
        public Language AppLanguage { get; set; }
        public Resolution Resolution { get; set; }

        public static string PrepareForFile(Settings s) => $"{s.TeamsGender}{Del}{s.AppLanguage}{Del}{s.Resolution}";
        public static Settings Parse(string s)
        {
            try
            {
                string[] details = s.Split(Del);
                Enum.TryParse(details[0], out Gender TeamsGender);
                Enum.TryParse(details[1], out Language AppLanguage);
                Enum.TryParse(details[2], out Resolution Resolution);
                
                
                return new Settings
                {
                    TeamsGender = TeamsGender,
                    AppLanguage = AppLanguage,
                    Resolution = Resolution
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override string ToString() => $"{TeamsGender}{Del}{AppLanguage}{Del}{Resolution}";

        
    }
}
