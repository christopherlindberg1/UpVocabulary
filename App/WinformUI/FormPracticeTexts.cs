using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformUI
{
    /// <summary>
    ///   Class containing the text for each element in FormPractice in
    ///   each language that will be used in the application.
    /// </summary>
    class FormPracticeTexts
    {
        // Form title
        public static string GetFormTitle_TextInEnglish() => "UpVocabulary - Practice";
        public static string GetFormTitle_TextInSwedish() => "UpVocabulary - Träning";


        // Main elements (not buttons)
        public static string GetLblHeading_TextInEnglish(string vocabularyName)
        {
            return $"Words from { vocabularyName }";
        }
        public static string GetLblHeading_TextInSwedish(string vocabularyName)
        {
            return $"Ord från { vocabularyName }";
        }

        public static string GetLblWordToTranslate_TextInEnglish(string word, string translationLanguage)
        {
            return $"Translate '{ word }' to { translationLanguage }";
        }
        public static string GetLblWordToTranslate_TextInSwedish(string word, string translationLanguage)
        {
            return $"Översätt '{ word }' till { translationLanguage }";
        }

        public static string GetLblToggleSentence_Show_TextInEnglish(string word)
        {
            return $"Show '{ word }' used in a sentence";
        }
        public static string GetLblToggleSentence_Show_TextInSwedish(string word)
        {
            return $"Visa '{ word }' i en mening";
        }
        public static string GetLblToggleSentence_Hide_TextInEnglish() => $"Hide sentence";
        public static string GetLblToggleSentence_Hide_TextInSwedish() => $"Dölj mening";

        public static string GetLblTranslation_TextInEnglish() => "Translation";
        public static string GetLblTranslation_TextInSwedish() => "Översättning";

        public static string GetLblCorrectOrWrong_Wrong_TextInEnglish() => "Wrong";
        public static string GetLblCorrectOrWrong_Wrong_TextInSwedish() => "Fel";
        public static string GetLblCorrectOrWrong_Correct_TextInEnglish() => "Correct";
        public static string GetLblCorrectOrWrong_Correct_TextInSwedish() => "Rätt";

        public static string GetLblCorrectTranslation_TextInEnglish(string correctTranslation)
        {
            return $"The correct translation is '{ correctTranslation }'";
        }
        public static string GetLblCorrectTranslation_TextInSwedish(string correctTranslation)
        {
            return $"Rätt översättning är '{ correctTranslation }'";
        }

        public static string GetLblToggleScore_Show_TextInEnglish() => "Show score";
        public static string GetLblToggleScore_Show_TextInSwedish() => "Visa poäng";
        public static string GetLblToggleScore_Hide_TextInEnglish() => "Hide score";
        public static string GetLblToggleScore_Hide_TextInSwedish() => "Dölj poäng";

        public static string GetLblScore_TextInEnglish() => "Score";
        public static string GetLblScore_TextInSwedish() => "Poäng";

        public static string GetLblNrOfCorrectAnswers_TextInEnglish(
            string nrOfCorrectAnswers,
            string totalAmountOfAnswers)
        {
            return $"{ nrOfCorrectAnswers } / { totalAmountOfAnswers } correct";
        }
        public static string GetLblNrOfCorrectAnswers_TextInSwedish(
            string nrOfCorrectAnswers,
            string totalAmountOfAnswers)
        {
            return $"{ nrOfCorrectAnswers } / { totalAmountOfAnswers } rätt";
        }


        // Buttons
        public static string GetBtnSubmitTranslation_TextInEnglish() => "Submit";
        public static string GetBtnSubmitTranslation_TextInSwedish() => "Svara";
        
        public static string GetBtnNextWord_TextInEnglish() => "Next word";
        public static string GetBtnNextWord_TextInSwedish() => "Nästa ord";

        public static string GetBtnPracticeAgain_TextInEnglish() => "Practice again";
        public static string GetBtnPracticeAgain_TextInSwedish() => "Träna igen";
        
        public static string GetBtnEndPractice_TextInEnglish() => "End practice";
        public static string GetBtnEndPractice_TextInSwedish() => "Avsluta träning";


        // Result elements
        public static string GetLblResults_TextInEnglish() => "Results";
        public static string GetLblResults_TextInSwedish() => "Resultat";
    }
}
