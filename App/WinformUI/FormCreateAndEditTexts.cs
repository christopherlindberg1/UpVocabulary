using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformUI
{
    /// <summary>
    ///   Class containing the text for each element in FormCreateAndEdit in
    ///   each language that will be used in the application.
    /// </summary>
    class FormCreateAndEditTexts
    {
        // Form title
        public static string GetFormTitle_CreateMode_TextInEnglish() => "UpVocabulary - Create new vocabulary";
        public static string GetFormTitle_CreateMode_TextInSwedish() => "UpVocabulary - Skapa ny ordlista";
        public static string GetFormTitle_EditMode_TextInEnglish() => "UpVocabulary - Edit vocabulary";
        public static string GetFormTitle_EditMode_TextInSwedish() => "UpVocabulary - Redigera ordlista";


        // Heading
        public static string GetLblHeading_CreateMode_TextInEnglish() => "Create new vocabulary";
        public static string GetLblHeading_CreateMode_TextInSwedish() => "Skapa ny ordlista";

        public static string GetLblHeading_EditMode_TextInEnglish() => "Edit vocabulary";
        public static string GetLblHeading_EditMode_TextInSwedish() => "Redigera ordlista";


        // Vocabulary elements
        public static string GetLblNameOfVocabulary_TextInEnglish() => "Name of the vocabulary";
        public static string GetLblNameOfVocabulary_TextInSwedish() => "Namn på ordlistan";

        public static string GetLblLanguages_TextInEnglish() => "Languages";
        public static string GetLblLanguages_TextInSwedish() => "Språk";

        public static string GetLblLanguageSwitch_TextInEnglish() => "to";
        public static string GetLblLanguageSwitch_TextInSwedish() => "till";


        // Word elements
        public static string GetLblWordTitle_CreateMode_TextInEnglish() => "Add word";
        public static string GetLblWordTitle_CreateMode_TextInSwedish() => "Lägg till ord";
        public static string GetLblWordTitle_EditMode_TextInEnglish() => "Edit word";
        public static string GetLblWordTitle_EditMode_TextInSwedish() => "Redigera ord";

        public static string GetLblWordInOriginalLanguage_Default_TextInEnglish() => "Word in original language";
        public static string GetLblWordInOriginalLanguage_Default_TextInSwedish() => "Ord i originalspråket";
        public static string GetLblWordInOriginalLanguage_SpecificToLanguage_TextInEnglish(string language)
        {
            // Does not yet translate the language itself to the selected application language
            return $"Word in { language }";
        }
        public static string GetLblWordInOriginalLanguage_SpecificToLanguage_TextInSwedish(string language)
        {
            // Does not yet translate the language itself to the selected application language
            return $"Ord på { language }";
        }

        public static string GetLblTranslationOfWord_Default_TextInEnglish() => "Translation";
        public static string GetLblTranslationOfWord_Default_TextInSwedish() => "Översättning";
        public static string GetLblTranslationOfWord_SpecificToLanguage_TextInEnglish(string language)
        {
            // Does not yet translate the language itself to the selected application language
            return $"Translation to { language }";
        }
        public static string GetLblTranslationOfWord_SpecificToLanguage_TextInSwedish(string language)
        {
            // Does not yet translate the language itself to the selected application language
            return $"Översättning till { language }";
        }

        public static string GetLblWordUsedInSentense_TextInEnglish() => "Word used in sentense (optional)";
        public static string GetLblWordUsedInSentense_TextInSwedish() => "Ord använt i mening (frivilligt)";
        
        public static string GetLblWordList_TextInEnglish() => "Words";
        public static string GetLblWordList_TextInSwedish() => "Ord";


        // Buttons
        public static string GetBtnSaveWord_TextInEnglish() => "Save word";
        public static string GetBtnSaveWord_TextInSwedish() => "Spara";

        public static string GetBtnCancelWordEditing_TextInEnglish() => "Cancel";
        public static string GetBtnCancelWordEditing_TextInSwedish() => "Avbryt";

        public static string GetBtnRemoveWords_TextInEnglish() => "Remove";
        public static string GetBtnRemoveWords_TextInSwedish() => "Ta bort";

        public static string GetBtnSaveVocabulary_TextInEnglish() => "Save vocabulary";
        public static string GetBtnSaveVocabulary_TextInSwedish() => "Spara ordlista";

        public static string GetBtnCancel_TextInEnglish() => "Cancel";
        public static string GetBtnCancel_TextInSwedish() => "Avbryt";
    }
}
