using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures
{
    public class Vocabulary
    {
        private string _name;
        private string _originalLanguage;
        private string _translationLanguage;
        private List<Word> _words = new List<Word>();
        private DateTime _dateLastUsed;
        private Random _random = new Random();




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

        private List<Word> Words
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

        public bool UpdateWord(string word, Word updatedWord)
        {
            Word wordToUpdate = GetWord(word);

            if (wordToUpdate == null)
            {
                return false;
            }

            // Don't have to bother with the order if OriginalWord is not changed.
            if (String.Compare(wordToUpdate.OriginalWord, updatedWord.OriginalWord, true) == 0)
            {
                wordToUpdate = new Word(updatedWord);
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

        public override string ToString()
        {
            return $"Name: { Name }";
        }
    }
}
