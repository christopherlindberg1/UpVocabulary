using System;
using System.Collections.Generic;
using System.Text;
using AppFeatures;

namespace AppFeatures.Tests
{
    public class VocabularyTests
    {
        private Vocabulary _sampleVocabulary;
        
        private Vocabulary SampleVocabulary
        {
            get => _sampleVocabulary;

            set => _sampleVocabulary = value ??
                throw new ArgumentNullException(
                    "SampleVocabulary",
                    "SampleVocabulary cannot be null.");
        }


        private void FillSampleVocabularyWithData()
        {
            Word w1 = new Word
            {
                OriginalWord = "b",
                Translation = "b",
                Sentence = "b b b",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w2 = new Word
            {
                OriginalWord = "c",
                Translation = "c",
                Sentence = "Ccc!",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w3 = new Word
            {
                OriginalWord = "e",
                Translation = "eeeeeee",
                Sentence = "Eeee ee ee eee",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };

            List<Word> sampleWords = new List<Word> { w1, w2, w3 };
            SampleVocabulary = new Vocabulary("D is for Digital", sampleWords, "English", "Swedish");
        }
    }
}
