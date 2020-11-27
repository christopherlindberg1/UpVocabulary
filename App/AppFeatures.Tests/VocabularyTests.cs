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
            (
                "b",
                "b",
                "b b b",
                5,
                0
            ),
            new Word
            (
                "c",
                "c",
                "Ccc!",
                5,
                0
            ),
            new Word
            (
                "e",
                "eeeeeee",
                "Eeee ee ee eee",
                5,
                0
            )
        };

        /// <summary>
        ///   Vocabulary initialized with sample data for all its fields. 3 words in total.
        /// </summary>
        private static Vocabulary _sampleVocabulary = new Vocabulary
            (
                "D is for Digital",
                SampleWords,
                "English",
                "Swedish"
            );

        private static Vocabulary _emptySampleVocabulary = new Vocabulary
            (
                "D is for Digital",
                new List<Word>(),
                "English",
                "Swedish"
            );




        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private static Vocabulary SampleVocabulary
        {
            get => _sampleVocabulary;

            set
            {
                _sampleVocabulary = value
                    ?? throw new ArgumentNullException(
                        "SampleVocabulary",
                        "SampleVocabulary cannot be null");
            }
        }

        private static Vocabulary EmptySampleVocabulary
        {
            get => _emptySampleVocabulary;
        }

        private static List<Word> SampleWords
        {
            get => _sampleWords;
        }




        /**
         * 
         * ===================  Tests  ===================
         * 
         */

        [Fact]
        public void GetWord_ShouldReturnFirstWord()
        {
            // Arrange
            Word expected = SampleWords[0];

            // Act
            Word actual = SampleVocabulary.GetWord("b");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWord_ShouldReturnLastWord()
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

        [Theory]
        [InlineData("b")]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void RemoveWord_ShouldWorkWhenEmpty(string word)
        {
            // Arrange
            bool expectedReturnValue = false;
            int expectedNrOfWordsLeft = 0;
            Word expectedGetWordAfterRemoval = null;

            // Act
            bool actualReturnValue = EmptySampleVocabulary.RemoveWord(word);
            int actualNrOfWordsLeft = EmptySampleVocabulary.NrOfWords;
            Word actualGetWordAfterRemoval = EmptySampleVocabulary.GetWord(word);

            // Assert
            Assert.Equal(expectedReturnValue, actualReturnValue);
            Assert.Equal(expectedNrOfWordsLeft, actualNrOfWordsLeft);
            Assert.Equal(expectedGetWordAfterRemoval, actualGetWordAfterRemoval);
        }

        [Fact]
        public void RemoveWord_ShouldWorkWhenNotEmpty()
        {
            // Arrange
            Word word = new Word("hello", "hej", null, 5, 0);
            bool expectedReturnValue = true;
            Word expectedWordToGetAfterDelete = null;
            int expectedNrOfWords = SampleVocabulary.NrOfWords;

            // Act
            SampleVocabulary.InsertWord(word);
            bool actualReturnValue = SampleVocabulary.RemoveWord(word.OriginalWord);
            Word actualWordAfterDelete = SampleVocabulary.GetWord(word.OriginalWord);
            int actualNrOfWords = SampleVocabulary.NrOfWords;

            // Assert
            Assert.Equal(expectedReturnValue, actualReturnValue);
            Assert.Equal(expectedWordToGetAfterDelete, actualWordAfterDelete);
            Assert.Equal(expectedNrOfWords, actualNrOfWords);
        }

        [Fact]
        public void RemoveWord_ShouldReturnFalseWhenWordDoesNotExist()
        {
            // Arrange
            Word word = new Word("hello", "hej", null, 5, 0);
            bool expectedReturnValue = false;
            Word expectedWordToGetAfterDelete = null;
            int expectedNrOfWords = SampleVocabulary.NrOfWords;

            // Act
            bool actualReturnValue = SampleVocabulary.RemoveWord(word.OriginalWord);
            Word ActualWordAfterDelete = SampleVocabulary.GetWord(word.OriginalWord);
            int actualNrOfWords = SampleVocabulary.NrOfWords;

            // Assert
            Assert.Equal(expectedReturnValue, actualReturnValue);
            Assert.Equal(expectedWordToGetAfterDelete, ActualWordAfterDelete);
            Assert.Equal(expectedNrOfWords, actualNrOfWords);
        }
    }
}
