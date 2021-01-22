using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures.SortingClasses
{
    public class SortVocabularyByOriginalLanguage : IComparer<Vocabulary>
    {
        public int Compare(Vocabulary x, Vocabulary y)
        {
            return x.OriginalLanguage.CompareTo(y.OriginalLanguage);
        }
    }
}
