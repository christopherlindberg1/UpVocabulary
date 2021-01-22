using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures.SortingClasses
{
    public class SortVocabularyByTranslationLanguage : IComparer<Vocabulary>
    {
        public int Compare(Vocabulary x, Vocabulary y)
        {
            return x.TranslationLanguage.CompareTo(y.TranslationLanguage);
        }
    }
}
