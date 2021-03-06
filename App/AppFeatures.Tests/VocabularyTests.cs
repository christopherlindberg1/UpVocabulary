﻿using System;
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
                "also",
                "också",
                "also also",
                2,
                0
            ),
            new Word
            (
                "can",
                "kan",
                "I can do it",
                5,
                0
            ),
            new Word
            (
                "paper",
                "papper",
                null,
                3,
                0
            )
        };

        private static Word _sampleWordNotInList = new Word
            (
                "hello",
                "hej",
                null,
                5,
                0
            );

        private static Word _sampleWordAlreadyInList = new Word
            (
                "also",
                "också",
                null,
                5,
                0
            );

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

        public static Vocabulary SampleVocabulary
        {
            get => _sampleVocabulary;

            set
            {
                _sampleVocabulary = value ??
                    throw new ArgumentNullException(
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

        private static Word SampleWordNotInList
        {
            get => _sampleWordNotInList;
        }

        private static Word SampleWordAlreadyInList
        {
            get => _sampleWordAlreadyInList;
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
            Word actual = SampleVocabulary.GetWord("also");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWord_ShouldReturnLastWord()
        {
            // Arrange
            Word expected = SampleWords[2];

            // Act
            Word actual = SampleVocabulary.GetWord("paper");

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

        
        public void GetWordAt_ShouldWork() 
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void InsertWord_ShouldWork()
        {
            // Arrange
            Word word = SampleWordNotInList;
            bool expectedReturnValue = true;
            int expectedNrOfWords = SampleVocabulary.NrOfWords + 1;
            int expectedIndexToBeAt = 2;

            // Act
            bool actualReturnValue = SampleVocabulary.InsertWord(word);
            int actualNrOfWords = SampleVocabulary.NrOfWords;
            Word fetchedWordByIndex = SampleVocabulary.GetWordAt(expectedIndexToBeAt);
            Word fetchedWordByOriginalWord = word;
            SampleVocabulary.RemoveWord(word.OriginalWord);

            // Assert
            Assert.Equal(expectedReturnValue, actualReturnValue);
            Assert.Equal(expectedNrOfWords, actualNrOfWords);
            Assert.Equal(word, fetchedWordByIndex);
            Assert.Equal(word, fetchedWordByOriginalWord);
        }

        [Fact]
        public void InsertWord_ShouldFail()
        {
            // Arrange
            Word word = _sampleWordAlreadyInList;
            bool expectedReturnValue = false;
            int expectedNrOfWords = SampleVocabulary.NrOfWords;

            // Act
            bool actualReturnValue = SampleVocabulary.InsertWord(word);
            int actualNrOfWords = SampleVocabulary.NrOfWords;

            // Assert
            Assert.Equal(expectedReturnValue, actualReturnValue);
            Assert.Equal(expectedNrOfWords, actualNrOfWords);
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
            Word word = SampleWordNotInList;
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
            Word word = SampleWordNotInList;
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

        /*
         * Test weighted random word generator.
         */

        

        /// <summary>
        ///   Runs a simulation to verify that the weighted random word generator
        ///   has the correct probability of generating each word.
        ///   The test compares the expected frequency to the actual frequency generated
        ///   in the sumulation.  
        ///   Since the results vary from execution to execution due to randomness,
        ///   a deviation of 1% (1% of the total nr of iterations) for the actual
        ///   frequency from the expected frequency is tolerated.
        /// </summary>
        [Fact]
        public void GenerateWeightedRandomWord_ShouldHaveAcceptableDistribution()
        {
            // Arrange
            int iterationsInSimulation = 100000;

            int wordAlsoFrequency = 0;      // Weight = 2
            int wordCanFrequency = 0;       // Weight = 5
            int wordPaperFrequency = 0;     // Weight = 3

            // Total weight = 10

            float deviationTolerance = 0.01f;

            /**
             * Calculate expected frequencies for each word.
             */

            float wordAlsoExpectedFrequency = (float)iterationsInSimulation * ((float)2 / (float)10);
            float wordCanExpectedFrequency = (float)iterationsInSimulation * ((float)5 / (float)10);
            float wordPaperExpectedFrequency = (float)iterationsInSimulation * ((float)3 / (float)10);

            /**
             * Calculate upper and lower limits for the expected frequency for each word,
             * taking into account the deviation tolerance level (tolerance for randomness).
             *
             */

            int[] wordAlsoLimits = new int[]
            {
                (int)Math.Ceiling((float)wordAlsoExpectedFrequency - (float)iterationsInSimulation * deviationTolerance),
                (int)((float)wordAlsoExpectedFrequency + (float)iterationsInSimulation * deviationTolerance)
            };

            int[] wordCanLimits = new int[]
            {
                (int)Math.Ceiling((float)wordCanExpectedFrequency - (float)iterationsInSimulation * deviationTolerance),
                (int)((float)wordCanExpectedFrequency + (float)iterationsInSimulation * deviationTolerance)
            };

            int[] wordPaperLimits = new int[]
            {
                (int)Math.Ceiling((float)wordPaperExpectedFrequency - (float)iterationsInSimulation * deviationTolerance),
                (int)((float)wordPaperExpectedFrequency + (float)iterationsInSimulation * deviationTolerance)
            };


            // Act
            for (int i = 0; i < iterationsInSimulation; i++)
            {
                Word generatedWord = SampleVocabulary.GenerateWeightedRandomWord();

                if (generatedWord == SampleWords[0])
                {
                    wordAlsoFrequency++;
                }
                else if (generatedWord == SampleWords[1])
                {
                    wordCanFrequency++;
                }
                else if (generatedWord == SampleWords[2])
                {
                    wordPaperFrequency++;
                }
            }


            // Assert
            Assert.True(wordAlsoFrequency >= wordAlsoLimits[0] && wordAlsoFrequency <= wordAlsoLimits[1]);
            Assert.True(wordCanFrequency >= wordCanLimits[0] && wordCanFrequency <= wordCanLimits[1]);
            Assert.True(wordPaperFrequency >= wordPaperLimits[0] && wordPaperFrequency <= wordPaperLimits[1]);
        }

        [Fact]
        public void GenerateWeightedRandomWord_ShouldReturnNull()
        {
            // Arrange
            Word expectedWord = null;

            // Act
            Word actualWord = EmptySampleVocabulary.GenerateWeightedRandomWord();

            // Assert
            Assert.Equal(expectedWord, actualWord);
        }
    }
}
