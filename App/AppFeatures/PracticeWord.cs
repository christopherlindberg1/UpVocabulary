using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures
{
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
