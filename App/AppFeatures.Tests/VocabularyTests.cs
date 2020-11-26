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
        ///   List of three sample words that will be used for testing.
        /// </summary>
        private static readonly List<Word> _sampleWords = new List<Word>
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
        };

        /// <summary>
        ///   Vocabulary initialized with sample data for all its fields. 3 words in total.
        /// </summary>
        private static readonly Vocabulary _sampleVocabulary = new Vocabulary
            (
                "D is for Digital",
                SampleWords,
                "English",
                "Swedish"
            );
        
        private static Vocabulary SampleVocabulary
        {
            get => _sampleVocabulary;
        }

        private static List<Word> SampleWords
        {
            get => _sampleWords;
        }


        [Fact]
        public void GetWord_ShouldReturnWord1()
        {
            // Arrange
            Word expected = SampleWords[0];

            // Act
            Word actual = SampleVocabulary.GetWord("b");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWord_ShouldReturnWord2()
        {
            // Arrange
            Word expected = SampleWords[1];

            // Act
            Word actual = SampleVocabulary.GetWord("c");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWord_ShouldReturnWord3()
        {
            // Arrange
            Word expected = SampleWords[2];

            // Act
            Word actual = SampleVocabulary.GetWord("e");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("bb")]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void GetWord_ShouldReturnNull(string word)
        {
            // Act
            Word actual = SampleVocabulary.GetWord(word);

            // Assert
            Assert.Null(actual);
        }
    }
}
