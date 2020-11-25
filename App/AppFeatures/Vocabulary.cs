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

        //public Vocabulary(params Word[] words)
        //{
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        Words.Add(words[i]);
        //    }
        //}





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        public Word this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Index",
                        "Index cannot be less than 0");
                }

                if (index > Words.Count - 1)
                {
                    throw new ArgumentOutOfRangeException(
                        "Index",
                        "Index was out of range");
                }

                return Words[index];
            }
        }

        public void AddSampleWords()
        {
            Word w1 = new Word
            {
                OriginalWord = "also",
                Translation = "också",
                Sentence = "I am also happy",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w2 = new Word
            {
                OriginalWord = "happy",
                Translation = "glad",
                Sentence = "I am happy",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w3 = new Word
            {
                OriginalWord = "hello",
                Translation = "hej",
                Sentence = "Hello there my little cat",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w4 = new Word
            {
                OriginalWord = "yes",
                Translation = "yes",
                Sentence = "yes, my name is Chris",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w5 = new Word
            {
                OriginalWord = "zoo",
                Translation = "zoo",
                Sentence = null,
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };

            Words.AddRange(new List<Word> { w1, w2, w3, w4, w5 });
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

            wordToUpdate = new Word(updatedWord);
            return true;
        }

        public bool RemoveWord(string wordToRemove)
        {
            Word word = GetWord(wordToRemove);

            if (word == null)
            {
                return false;
            }
            else
            {
                Words.Remove(word);
                return true;
            }
        }

        public Dictionary<string, string> GetVocabularyInfo()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();

            info.Add("name", Name);
            info.Add("nrOfWords", NrOfWords.ToString());
            info.Add("languages", $"{ OriginalLanguage } - { TranslationLanguage }");

            return info;
        }
    }
}
