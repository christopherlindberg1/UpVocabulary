using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures
{
    public static class LanguagesTranslationMap
    {
        public static Dictionary<string, Dictionary<AppLanguages, string>> Map = new Dictionary<string, Dictionary<AppLanguages, string>>
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

        /// <summary>
        ///   Translates a language to english
        /// </summary>
        /// <param name="language">Language that is used in the vocabulary, spelled out
        /// in one of the available app languages</param>
        /// <returns>Language translated to english</returns>
        public static string TranslateLanguageToEnglish(string languageToTranslate)
        {
            foreach (var language in LanguagesTranslationMap.Map.Keys)
            {
                if (LanguagesTranslationMap.Map[language].ContainsValue(languageToTranslate))
                {
                    return language;
                }
            }

            throw new InvalidOperationException("Could not translate language back to english");
        }
    }
}
