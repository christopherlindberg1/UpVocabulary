using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures
{
    /// <summary>
    ///   Helper class for the Word class.
    ///   Is used to keep track of data during a practice session.
    /// </summary>
    public class PracticeWord
    {
        public Word Word { get; set; }
        public string UserTranslation { get; set; }
        public bool CorrectTranslation { get; set; }

        public PracticeWord(Word word, string userTranslation, bool correctTranslation)
        {
            Word = word;
            UserTranslation = userTranslation;
            CorrectTranslation = correctTranslation;
        }
    }
}
