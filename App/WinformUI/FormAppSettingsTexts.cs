using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformUI
{
    /// <summary>
    ///   Class containing the text for each element in FormAppSettings in
    ///   each language that will be used in the application.
    /// </summary>
    class FormAppSettingsTexts
    {
        // Heading
        public static string GetLblSettingsHeading_TextInEnglish() => "Settings";
        public static string GetLblSettingsHeading_TextInSwedish() => "Inställningar";


        // Language setting elements
        public static string GetLblLanguage_TextInEnglish() => "Language";
        public static string GetLblLanguage_TextInSwedish() => "Språk";

        public static string GetBtnLanguageEnglish_TextInEnglish() => "English";
        public static string GetBtnLanguageEnglish_TextInSwedish() => "Engelska";

        public static string GetBtnLanguageSwedish_TextInEnglish() => "Swedish";
        public static string GetBtnLanguageSwedish_TextInSwedish() => "Svenska";


        // Auto prompt setting elements
        public static string GetLblAutoPrompt_TextInEnglish() => "Prompt next word automatically";
        public static string GetLblAutoPrompt_TextInSwedish() => "Fråga om nästa ord automatiskt";

        public static string GetLblAutoPromptCorrect_TextInEnglish() => "After correct translation";
        public static string GetLblAutoPromptCorrect_TextInSwedish() => "Efter korrekt översättning";

        public static string GetBtnAutoPromptCorrectYes_TextInEnglish() => "Yes";
        public static string GetBtnAutoPromptCorrectYes_TextInSwedish() => "Ja";

        public static string GetBtnAutoPromptCorrectNo_TextInEnglish() => "No";
        public static string GetBtnAutoPromptCorrectNo_TextInSwedish() => "Nej";

        public static string GetLblAutoPromptIncorrect_TextInEnglish() => "After incorrect translation";
        public static string GetLblAutoPromptIncorrect_TextInSwedish() => "Efter felaktig översättning";

        public static string GetBtnAutoPromptIncorrectYes_TextInEnglish() => "Yes";
        public static string GetBtnAutoPromptIncorrectYes_TextInSwedish() => "Ja";

        public static string GetBtnAutoPromptIncorrectNo_TextInEnglish() => "No";
        public static string GetBtnAutoPromptIncorrectNo_TextInSwedish() => "Nej";


        // Delay for auto prompt setting elements
        public static string GetLblDelayBeforePrompt_TextInEnglish() => "Delay before prompting next word (in milliseconds)";
        public static string GetLblDelayBeforePrompt_TextInSwedish() => "Fördröjning innan nästa ord frågas (i millisekunder)";

        public static string GetLblDelayBeforePromptCorrect_TextInEnglish() => "After correct translation";
        public static string GetLblDelayBeforePromptCorrect_TextInSwedish() => "Efter korrekt översättning";

        public static string GetLblDelayBeforePromptIncorrect_TextInEnglish() => "After incorrect translation";
        public static string GetLblDelayBeforePromptIncorrect_TextInSwedish() => "Efter felaktig översättning";


        // Buttons
        public static string GetBtnSaveSettings_TextInEnglish() => "Save";
        public static string GetBtnSaveSettings_TextInSwedish() => "Spara";
    }
}
