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
        public static string GetLblHeadingTextInEnglish() => "Your vocabularies";
        public static string GetLblHeadingTextInSwedish() => "Dina ordlistor";


        // Buttons
        public static string GetBtnCreateNewVocabularyTextInEnglish() => "Create new vocabulary";
        public static string GetBtnCreateNewVocabularyTextInSwedish() => "Skapa ny ordlista";

        public static string GetBtnStartPracticeTextInEnglish() => "Practice";
        public static string GetBtnStartPracticeTextInSwedish() => "Öva";

        public static string GetBtnEditVocabularyTextInEnglish() => "Edit";
        public static string GetBtnEditVocabularyTextInSwedish() => "Redigera";

        public static string GetBtnRemoveVocabulariesTextInEnglish() => "Remove";
        public static string GetBtnRemoveVocabulariesTextInSwedish() => "Ta bort";


        // Listview column names
        public static string GetListViewVocabularies_NameTextInEnglish() => "Name";
        public static string GetListViewVocabularies_NameTextInSwedish() => "Namn";

        public static string GetListViewVocabularies_NrOfWordsTextInEnglish() => "Nr of words";
        public static string GetListViewVocabularies_NrOfWordsTextInSwedish() => "Antal ord";
        
        public static string GetListViewVocabularies_LanguagesTextInEnglish() => "Languages";
        public static string GetListViewVocabularies_LanguagesTextInSwedish() => "Språk";
        
        public static string GetListViewVocabularies_DateLastUsedTextInEnglish() => "Last time used";
        public static string GetListViewVocabularies_DateLastUsedTextInSwedish() => "Senast använd";


    }
}
