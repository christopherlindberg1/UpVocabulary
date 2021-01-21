using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformUI
{
    /// <summary>
    ///   Class containing the text for each element in FormPracticeSettings in
    ///   each language that will be used in the application.
    /// </summary>
    class FormPracticeSettingsTexts
    {
        // Form title
        public static string GetFormTitle_TextInEnglish() => "UpVocabulary - Practice settings";
        public static string GetFormTitle_TextInSwedish() => "UpVocabulary - Inställningar för Träningssession";


        // Heading
        public static string GetLblHeading_TextInEnglish() => "Configure your practice session";
        public static string GetLblHeading_TextInSwedish() => "Konfigurera din träningssession";


        // Main elements
        public static string GetLblDescription_TextInEnglish(string voabularyName)
        {
            return  $"Configure your practice session for { voabularyName }";
        }
        public static string GetLblDescription_TextInSwedish(string voabularyName)
        {
            return $"Konfigurera din träningssession för { voabularyName }";
        }

        public static string GetLblLanguages_TextInEnglish() => "Language";
        public static string GetLblLanguages_TextInSwedish() => "Språk";

        public static string GetLblAmountOfWords_TextInEnglish() => "Amount of words";
        public static string GetLblAmountOfWords_TextInSwedish() => "Antal ord";


        // Buttons
        public static string GetBtnStartPractice_TextInEnglish() => "Start practice";
        public static string GetBtnStartPractice_TextInSwedish() => "Starta träning";

        public static string GetBtnCancel_TextInEnglish() => "Cancel";
        public static string GetBtnCancel_TextInSwedish() => "Avbryt";
    }
}
