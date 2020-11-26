using System;
using System.Collections.Generic;
using System.Text;
using AppFeatures;
using Xunit;

namespace AppFeatures.Tests
{
    public class VocabularyTests
    {
        /// <summary>
        ///   Vocabulary field initialized with sample data for all fields. 3 words in total.
        /// </summary>
        private readonly Vocabulary _sampleVocabulary =
            new Vocabulary(
                "D is for Digital",
                new List<Word>
                {
                    new Word
                    {
                        OriginalWord = "b",
                        Translation = "b",
                        Sentence = "b b b",
                        Weight = 5,
                        TimesAnsweredCorrectly = 0
                    },
                    new Word
                    {
                        OriginalWord = "c",
                        Translation = "c",
                        Sentence = "Ccc!",
                        Weight = 5,
                        TimesAnsweredCorrectly = 0
                    },
                    new Word
                    {
                        OriginalWord = "e",
                        Translation = "eeeeeee",
                        Sentence = "Eeee ee ee eee",
                        Weight = 5,
                        TimesAnsweredCorrectly = 0
                    }

                },
                "English",
                "Swedish");
        
        private Vocabulary SampleVocabulary
        {
            get => _sampleVocabulary;
        }


        

        [Fact]
        public void Test()
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = true;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
