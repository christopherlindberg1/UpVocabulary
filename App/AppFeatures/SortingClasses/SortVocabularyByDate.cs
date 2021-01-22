using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures.SortingClasses
{
    public class SortVocabularyByDate : IComparer<Vocabulary>
    {
        public int Compare(Vocabulary x, Vocabulary y)
        {
            return x.DateLastUsed.CompareTo(y.DateLastUsed);
        }
    }
}
