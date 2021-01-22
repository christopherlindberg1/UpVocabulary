using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures
{
    public static class LanguagesTranslationMap
    {
        private static Dictionary<string, Dictionary<AppLanguages, string>> _map = new Dictionary<string, Dictionary<AppLanguages, string>>
        {
            { 
                "albanian", new Dictionary<AppLanguages, string> {
                    { AppLanguages.English, "albanian" },
                    { AppLanguages.Swedish, "albanska" }}
            },
            { 
                "english", new Dictionary<AppLanguages, string> {
                    { AppLanguages.English, "english" },
                    { AppLanguages.Swedish, "engelska" }
                }
            },
            {
                "german", new Dictionary<AppLanguages, string> {
                    { AppLanguages.English, "german" },
                    { AppLanguages.Swedish, "tyska" }
                }
            },
            {
                "spanish", new Dictionary<AppLanguages, string> {
                    { AppLanguages.English, "spanish" },
                    { AppLanguages.Swedish, "spanska" }
                }
            },
            {
                "swedish", new Dictionary<AppLanguages, string> {
                    { AppLanguages.English, "swedish" },
                    { AppLanguages.Swedish, "svenska" }
                }
            }
        };


        public static Dictionary<string, Dictionary<AppLanguages, string>> Map
        {
            get => _map;
        }
    }
}
