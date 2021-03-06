﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures.SortingClasses
{
    public class SortVocabularyByNrOfWords : IComparer<Vocabulary>
    {
        public int Compare(Vocabulary x, Vocabulary y)
        {
            return x.NrOfWords.CompareTo(y.NrOfWords);
        }
    }
}
