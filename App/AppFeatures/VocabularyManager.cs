using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures
{
    public class VocabularyManager
    {
        private readonly List<Vocabulary> _vocabularies = new List<Vocabulary>();





        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private List<Vocabulary> Vocabularies
        {
            get => _vocabularies;

            //set
            //{
            //    if (value == null)
            //    {
            //        throw new ArgumentNullException(
            //            "Vocabularies",
            //            "Vocabularies cannot be null");
            //    }
            //}
        }

        public int NrOfVocabularies
        {
            get => Vocabularies.Count;
        }





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public VocabularyManager()
        {
            //Vocabularies = new List<Vocabulary>();
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        public Vocabulary GetVocabulary(string name)
        {
            for (int i = 0; i < Vocabularies.Count; i++)
            {
                if (String.Compare(Vocabularies[i].Name, name, false) == 0)
                {
                    return Vocabularies[i];
                }
            }

            return null;
        }

        public Vocabulary GetVocabularyAt(int index)
        {
            if (index < 0 || index > Vocabularies.Count - 1)
            {
                return null;
            }

            return Vocabularies[index];
        }

        public Vocabulary GetCopyOfVocabulary(int index)
        {
            Vocabulary originalVocabulary = GetVocabularyAt(index);

            if (originalVocabulary == null)
            {
                return null;
            }

            Vocabulary copy = new Vocabulary();

            Vocabulary.CopyVocabulary(originalVocabulary, copy);

            return copy;
        }

        public bool AddVocabulary(Vocabulary vocabulary)
        {
            Vocabulary existingVocabulary = GetVocabulary(vocabulary.Name);

            if (existingVocabulary != null)
            {
                return false;
            }

            Vocabularies.Add(vocabulary);
            return true;
        }

        public void UpdateVocabulary(Vocabulary originalVocabulary, Vocabulary updatedVocabulary)
        {
            Vocabulary.CopyVocabulary(updatedVocabulary, originalVocabulary);
        }

        public bool RemoveAt(int index)
        {
            Vocabulary vocabulary = GetVocabularyAt(index);

            if (vocabulary == null)
            {
                return false;
            }

            Vocabularies.RemoveAt(index);
            return true;
        }

        public string[] GetNamesForAllVocabularies()
        {
            string[] vocabularyNames = new string[Vocabularies.Count];

            for (int i = 0; i < Vocabularies.Count; i++)
            {
                vocabularyNames[i] = GetVocabularyAt(i).Name;
            }

            return vocabularyNames;
        }
    }
}
