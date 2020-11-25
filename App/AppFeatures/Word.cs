using System;
using System.Collections.Generic;
using System.Text;

namespace AppFeatures
{
    public class Word
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

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        "Sentence",
                        "Sentence cannot be null");
                }

                _sentence = value;
            }
        }

        public int  Weight
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
            get => _weight;

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

                _weight = value;
            }
        }






        /**
         * 
         * ===================  Methods  ===================
         * 
         */

    }
}
