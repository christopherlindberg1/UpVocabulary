using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;


namespace AppFeatures
{
    /// <summary>
    ///   Class for word objects that can be added to Vocabulary objects.
    /// </summary>
    [Serializable()]
    public class Word : ISerializable
    {
        private string _originalWord;
        private string _translation;
        private string _sentence;
        private int _weight;
        private int _timesAnsweredCorrectly;





        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        public string OriginalWord
        {
            get => _originalWord;

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        "OriginalWord",
                        "OriginalWord cannot be null");
                }

                _originalWord = value;
            }
        }

        public string Translation
        {
            get => _translation;

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        "Translation",
                        "Translation cannot be null");
                }

                _translation = value;
            }
        }

        public string Sentence
        {
            get => _sentence;

            set => _sentence = value;
        }

        public int Weight
        {
            get => _weight;

            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(
                        "Weight",
                        "Weight cannot be less than 1");
                }

                if (value > 5)
                {
                    throw new ArgumentOutOfRangeException(
                        "Weight",
                        "Weight cannot be greater than 5");
                }

                _weight = value;
            }
        }

        public int TimesAnsweredCorrectly
        {
            get => _timesAnsweredCorrectly;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "TimesAnsweredCorrectly",
                        "TimesAnsweredCorrectly cannot be less than 0");
                }

                if (value > 1)
                {
                    throw new ArgumentOutOfRangeException(
                        "TimesAnsweredCorrectly",
                        "TimesAnsweredCorrectly cannot be greater than 1");
                }

                _timesAnsweredCorrectly = value;
            }
        }





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public Word()
        {
        }

        public Word(
            string originalWord,
            string translation,
            string sentence)
        {
            OriginalWord = originalWord;
            Translation = translation;
            Sentence = sentence;
            Weight = 5;
            TimesAnsweredCorrectly = 0;
        }

        public Word(
            string originalWord,
            string translation,
            string sentence,
            int weight,
            int timesAnsweredCorrectly)
        {
            OriginalWord = originalWord;
            Translation = translation;
            Sentence = sentence;
            Weight = weight;
            TimesAnsweredCorrectly = timesAnsweredCorrectly;
        }

        public Word(Word wordToCopy)
        {
            OriginalWord = wordToCopy.OriginalWord;
            Translation = wordToCopy.Translation;
            Sentence = wordToCopy.Sentence;
            Weight = wordToCopy.Weight;
            TimesAnsweredCorrectly = wordToCopy.TimesAnsweredCorrectly;
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        /// <summary>
        ///   Method for copying the properties of a word that the user is able
        ///   to modify. Does not copy Weight and TimesAnsweredCorrectly
        /// </summary>
        public static void CopyWord(Word wordToUpdate, Word wordToCopyFrom)
        {
            wordToUpdate.OriginalWord = wordToCopyFrom.OriginalWord;
            wordToUpdate.Translation = wordToCopyFrom.Translation;
            wordToUpdate.Sentence = wordToCopyFrom.Sentence;
        }

        /// <summary>
        ///   Method for serializing Word objects.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("OriginalWord", OriginalWord);
            info.AddValue("Translation", Translation);
            info.AddValue("Sentence", Sentence);
            info.AddValue("Weight", Weight);
            info.AddValue("TimesAnsweredCorrectly", TimesAnsweredCorrectly);
        }

        /// <summary>
        ///   Constructor for deserializing Word objects.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Word(SerializationInfo info, StreamingContext context)
        {
            OriginalWord = (string)info.GetValue("OriginalWord", typeof(string));
            Translation = (string)info.GetValue("Translation", typeof(string));
            Sentence = (string)info.GetValue("Sentence", typeof(string));
            Weight = (int)info.GetValue("Weight", typeof(int));
            TimesAnsweredCorrectly = (int)info.GetValue("TimesAnsweredCorrectly", typeof(int));
        }

        public override string ToString()
        {
            return $"{ OriginalWord } - { Translation }";
        }
    }
}
