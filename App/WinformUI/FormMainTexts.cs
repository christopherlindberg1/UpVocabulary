using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformUI
{
    /// <summary>
    ///   Class containing the text for each element in FormMain in
    ///   each language that will be used in the application.
    /// </summary>
    class FormMainTexts
    {
        // Heading
        public static string GetLblHeading_TextInEnglish() => "Your vocabularies";
        public static string GetLblHeading_TextInSwedish() => "Dina ordlistor";


        // Buttons
        public static string GetBtnCreateNewVocabulary_TextInEnglish() => "Create new vocabulary";
        public static string GetBtnCreateNewVocabulary_TextInSwedish() => "Skapa ny ordlista";

        public static string GetBtnStartPractice_TextInEnglish() => "Practice";
        public static string GetBtnStartPractice_TextInSwedish() => "Öva";

        public static string GetBtnEditVocabulary_TextInEnglish() => "Edit";
        public static string GetBtnEditVocabulary_TextInSwedish() => "Redigera";

        public static string GetBtnRemoveVocabularies_TextInEnglish() => "Remove";
        public static string GetBtnRemoveVocabularies_TextInSwedish() => "Ta bort";


        // Listview column names
        public static string GetListViewVocabularies_Name_TextInEnglish() => "Name";
        public static string GetListViewVocabularies_Name_TextInSwedish() => "Namn";

        public static string GetListViewVocabularies_NrOfWords_TextInEnglish() => "Nr of words";
        public static string GetListViewVocabularies_NrOfWords_TextInSwedish() => "Antal ord";
        
        public static string GetListViewVocabularies_OriginalLanguage_TextInEnglish() => "Original language";
        public static string GetListViewVocabularies_OriginalLanguage_TextInSwedish() => "Originalspråk";

        public static string GetListViewVocabularies_TranslationLanguage_TextInEnglish() => "Translaiton language";
        public static string GetListViewVocabularies_TranslationLanguage_TextInSwedish() => "Översättningsspråk";

        public static string GetListViewVocabularies_DateLastUsed_TextInEnglish() => "Last time used";
        public static string GetListViewVocabularies_DateLastUsed_TextInSwedish() => "Senast använd";


    }
}
