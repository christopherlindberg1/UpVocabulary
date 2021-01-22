using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using AppFeatures.SortingClasses;

namespace AppFeatures
{
    /// <summary>
    ///   Class used to create vocabulary managers that maintain vocabularies.
    /// </summary>
    [Serializable()]
    public class VocabularyManager : ISerializable
    {
        private List<Vocabulary> _vocabularies = new List<Vocabulary>();
        




        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        public List<Vocabulary> Vocabularies
        {
            get => _vocabularies;

            set => _vocabularies = value ??
                throw new ArgumentNullException(
                    "Vocabularies",
                    "Vocabularies cannot be null.");

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

        /// <summary>
        ///   Returns a copy of a vocabulary instead of the reference.
        /// </summary>
        /// <param name="index">index of the vocabulary</param>
        /// <returns>Copy of the vocabulary at a given index.</returns>
        public Vocabulary GetCopyOfVocabulary(int index)
        {
            Vocabulary originalVocabulary = GetVocabularyAt(index);

            if (originalVocabulary == null)
            {
                return null;
            }

            Vocabulary copy = new Vocabulary();

            Vocabulary.CopyVocabulary(copy, originalVocabulary);

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

        /// <summary>
        ///   Updates a vocabulary by copying the properties of an updated vocabulary.
        /// </summary>
        /// <param name="originalVocabulary">Vocabulary to change.</param>
        /// <param name="updatedVocabulary">Vocabulary to copy from.</param>
        public void UpdateVocabulary(Vocabulary originalVocabulary, Vocabulary updatedVocabulary)
        {
            Vocabulary.CopyVocabulary(originalVocabulary, updatedVocabulary);
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

        public void Sort(IComparer<Vocabulary> sorter, SortingDirections direction)
        {
            Vocabularies.Sort(sorter);

            if (direction == SortingDirections.Desc)
            {
                Vocabularies.Reverse();
            }
        }

        /// <summary>
        ///   Method for serializing VocabularyManager objects.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Vocabularies", Vocabularies);
        }

        /// <summary>
        ///   Method for deserializing VocabularyManager objects.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public VocabularyManager(SerializationInfo info, StreamingContext context)
        {
            Vocabularies = (List<Vocabulary>)info.GetValue("Vocabularies", typeof(List<Vocabulary>));
        }
    }
}
