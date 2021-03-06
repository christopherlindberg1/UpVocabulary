﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures.SortingClasses
{
    public class SortVocabularyByName : IComparer<Vocabulary>
    {
        public int Compare(Vocabulary x, Vocabulary y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
