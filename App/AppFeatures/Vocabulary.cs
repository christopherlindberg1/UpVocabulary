using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace AppFeatures
{
    /// <summary>
    ///   Class used to create Vocabulary objects that
    ///   keep track of collections of words.
    /// </summary>
    [Serializable()]
    public class Vocabulary : ISerializable
    {
        private string _name;
        private string _originalLanguage;
        private string _translationLanguage;
        private List<Word> _words = new List<Word>();
        private DateTime _dateLastUsed;
        private readonly Random _random = new Random();




        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        public string Name
        {
            get => _name;

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name", "Name cannot be null");
                }

                _name = value;
            }
        }

        public string OriginalLanguage
        {
            get => _originalLanguage;

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        "OriginalLanguage",
                        "OriginalLanguage cannot be null");
                }

                _originalLanguage = value;
            }
        }

        public string TranslationLanguage
        {
            get => _translationLanguage;

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        "TranslationLanguage",
                        "TranslationLanguage cannot be null");
                }

                _translationLanguage = value;
            }
        }

        public List<Word> Words
        {
            get => _words;

            set
            {
                _words = value ?? throw new ArgumentNullException("Words", "Words cannot be null.");
            }
        }

        public DateTime DateLastUsed
        {
            get => _dateLastUsed;

            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(
                        "DateLastUsed",
                        "DateLastUsed cannot be in the future.");
                }

                _dateLastUsed = value;
            }
        }

        private Random RandomObject
        {
            get => _random;
        }

        public int NrOfWords => _words.Count;





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public Vocabulary()
        {
            DateLastUsed = DateTime.Now.Date;
        }

        public Vocabulary(
            string name,
            List<Word> words,
            string originalLanguage,
            string translationLanguage)
        {
            Name = name;
            Words = words;
            OriginalLanguage = originalLanguage;
            TranslationLanguage = translationLanguage;
            DateLastUsed = DateTime.Now.Date;
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        /// <summary>
        ///   Returns word at a given index. Returns null if index is out of range.
        /// </summary>
        /// <param name="index">Index of the word</param>
        /// <returns>Word object</returns>
        public Word GetWordAt(int index)
        {
            if (index < 0 || index > Words.Count - 1)
            {
                return null;
            }

            return Words[index];
        }

        /// <summary>
        ///   Gets a Word object which's OriginalWord property matches the provided argument.
        /// </summary>
        /// <param name="word">word</param>
        /// <returns>Word object if there is a match, null otherwise.</returns>
        public Word GetWord(string word)
        {
            for (int i = 0; i < Words.Count; i++)
            {
                if (String.Compare(Words[i].OriginalWord, word, true) == 0)
                {
                    return Words[i];
                }
            }

            return null;
        }

        public bool WordExists(string word)
        {
            if (GetWord(word) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        ///   Inserts a Word object in order.
        ///   The collection is ordered by the OriginalWord property.
        /// </summary>
        /// <param name="word">Word to insert</param>
        /// <returns>true if word got inserted, false otherwise.</returns>
        public bool InsertWord(Word word)
        {
            bool hasInserted = false;

            for (int i = 0; i < Words.Count; i++)
            {
                // Don't insert if word already exists
                if (String.Compare(word.OriginalWord, Words[i].OriginalWord, true) == 0)
                {
                    return false;
                }

                else if (String.Compare(word.OriginalWord, Words[i].OriginalWord, true) == -1)
                {
                    Words.Insert(i, word);
                    return true;
                }
            }

            // True if new word comes after every existing word in alphabetic order
            if (hasInserted == false)
            {
                // Adds word to the end of the list
                Words.Add(word);
                hasInserted = true;
            }

            return hasInserted;
        }

        /// <summary>
        ///   Updates the properties of a word by copying them from another.
        /// </summary>
        /// <param name="wordToUpdate">Word to update.</param>
        /// <param name="updatedWord">Word to copy from.</param>
        /// <returns>true if word got updated, false otherwise.</returns>
        public bool UpdateWord(Word wordToUpdate, Word updatedWord)
        {
            //Word wordToUpdate = GetWord(word);

            if (wordToUpdate == null)
            {
                return false;
            }

            // Don't have to bother with the order if OriginalWord is not changed.
            if (String.Compare(wordToUpdate.OriginalWord, updatedWord.OriginalWord, true) == 0)
            {
                Word.CopyWord(wordToUpdate, updatedWord);
            }
            // Have to insert word in alphabetical order if OriginalWord is changed.
            else
            {
                Words.Remove(wordToUpdate);
                InsertWord(updatedWord);
            }

            return true;
        }

        public bool RemoveWord(string wordToRemove)
        {
            Word word = GetWord(wordToRemove);

            return Words.Remove(word);
        }

        public bool RemoveWordAt(int index)
        {
            Word word = GetWordAt(index);

            if (word == null)
            {
                return false;
            }

            Words.RemoveAt(index);
            return true;
        }

        /// <summary>
        ///   Copies a vocabulary by setting its properties to those
        ///   of another vocabulary.
        /// </summary>
        /// <param name="vocabularyToCopyFrom">Vocabulary to copy from.</param>
        /// <param name="vocabularyToChange">Vocabulary to change.</param>
        public static void CopyVocabulary(Vocabulary vocabularyToCopyFrom, Vocabulary vocabularyToChange)
        {
            vocabularyToChange.Name = vocabularyToCopyFrom.Name;
            vocabularyToChange.OriginalLanguage = vocabularyToCopyFrom.OriginalLanguage;
            vocabularyToChange.TranslationLanguage = vocabularyToCopyFrom.TranslationLanguage;
            vocabularyToChange.DateLastUsed = vocabularyToCopyFrom.DateLastUsed;

            Word[] copyOfWords = new Word[vocabularyToCopyFrom.Words.Count];
            vocabularyToCopyFrom.Words.CopyTo(copyOfWords);
            vocabularyToChange.Words = new List<Word>(copyOfWords);
        }

        /// <summary>
        ///   Gets a string[] with the ToString() representation
        ///   for all words.
        /// </summary>
        /// <returns>string[] with representations for all words.</returns>
        public string[] GetWordsWithTranslation()
        {
            string[] words = new string[Words.Count];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Words[i].ToString();
            }

            return words;
        }

        private int GetTotalWeightOfAllWords()
        {
            int totalWeight = 0;

            for (int i = 0; i < Words.Count; i++)
            {
                totalWeight += GetWordAt(i).Weight;
            }

            return totalWeight;
        }

        public Word GenerateWeightedRandomWord()
        {
            if (Words.Count == 0)
            {
                return null;
            }

            int totalWeight = GetTotalWeightOfAllWords();
            int randomNumber = RandomObject.Next(1, totalWeight + 1);
            int counter = 0;

            for (int i = 0; i < Words.Count; i++)
            {
                counter += Words[i].Weight;

                if (counter >= randomNumber)
                {
                    return Words[i];
                }
            }

            // Should never get here, no matter what randomNumber is.
            throw new InvalidOperationException("Method is incorrectly implemented");
        }

        public Dictionary<string, string> GetVocabularyInfo()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();

            info.Add("name", Name);
            info.Add("nrOfWords", NrOfWords.ToString());
            info.Add("languages", $"{ OriginalLanguage } - { TranslationLanguage }");

            return info;
        }

        public void UpdateWeightOfWord(Word word, bool answeredCorractly)
        {
            if (answeredCorractly == false)
            {
                if (word.Weight == 5)
                {
                    return;
                }
                else
                {
                    word.Weight++;
                }
            }
            else
            {
                if (word.Weight == 1)
                {
                    return;
                }
                else
                {
                    if (word.TimesAnsweredCorrectly == 1)
                    {
                        word.Weight--;
                        word.TimesAnsweredCorrectly = 0;
                    }
                    else
                    {
                        word.TimesAnsweredCorrectly++;
                    }
                }
            }
        }

        public void UpdateDateLastUsed()
        {
            DateLastUsed = DateTime.Now.Date;
        }

        public override string ToString()
        {
            return $"Name: { Name }";
        }
        
        /// <summary>
        ///   Method for serializing Vocabulary objects.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("OriginalLanguage", OriginalLanguage);
            info.AddValue("TranslationLanguage", TranslationLanguage);
            info.AddValue("Words", Words);
            info.AddValue("DateLastUsed", DateLastUsed);
        }

        /// <summary>
        ///   Method for deserializing Vocabulary objects.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Vocabulary(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            OriginalLanguage = (string)info.GetValue("OriginalLanguage", typeof(string));
            TranslationLanguage = (string)info.GetValue("TranslationLanguage", typeof(string));
            Words = (List<Word>)info.GetValue("Words", typeof(List<Word>));
            DateLastUsed = (DateTime)info.GetValue("DateLastUsed", typeof(DateTime));
        }
    }
}
