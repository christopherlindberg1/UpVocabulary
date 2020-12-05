using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFeatures;

namespace WinformUI
{
    public partial class FormPractice : Form
    {
        private readonly InputValidator _inputValidator = new InputValidator();
        private Vocabulary _vocabulary;
        private string _originalLanguage;
        private string _translationLanguage;
        private int _nrOfWordsToPracticeWith;
        private bool _promptWithOriginalLanguage;
        private bool _useLimitedAmountOfWords;
        private readonly Queue<string> _lastUsedWords = new Queue<string>();





        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private InputValidator InputValidator
        {
            get => _inputValidator;
        }

        private Vocabulary Vocabulary
        {
            get => _vocabulary;

            set
            {
                _vocabulary = value ??
                    throw new ArgumentNullException(
                        "VocabularyToPracticeWith",
                        "VocabularyToPracticeWith cannot be null.");
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

        public int NrOfWordsToPracticeWith
        {
            get => _nrOfWordsToPracticeWith;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "NrOfWordsToPracticeWith",
                        "Must be at least zero");
                }
                else
                {
                    _nrOfWordsToPracticeWith = value;
                }
            }
        }

        public bool PromptWithOriginalLanguage
        {
            get => _promptWithOriginalLanguage;

            set => _promptWithOriginalLanguage = value;
        }

        public bool UseLimitedAmountOfWords
        {
            get => _useLimitedAmountOfWords;

            set => _useLimitedAmountOfWords = value;
        }

        private Queue<string> LastUsedWords
        {
            get => _lastUsedWords;
        }





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormPractice(
            Vocabulary vocabulary,
            string originalLanguage,
            string translationLanguage,
            int nrOfWordsToPracticeWith,
            bool promptWithOriginalLanguage,
            bool useLimitedAmountOfWords)
        {
            InitializeComponent();

            Vocabulary = vocabulary;
            OriginalLanguage = originalLanguage;
            TranslationLanguage = translationLanguage;
            NrOfWordsToPracticeWith = nrOfWordsToPracticeWith;
            PromptWithOriginalLanguage = promptWithOriginalLanguage;
            UseLimitedAmountOfWords = useLimitedAmountOfWords;

            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeGUI();
        }

        private void InitializeGUI()
        {

        }

        private void InitializeDescription()
        {

        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private bool LastUsedWordsContains(string word)
        {
            return LastUsedWords.Contains(word);
        }

        /// <summary>
        ///   Adds a word to the queue. Dequeues the word at the beginning of
        ///   the queue if there was three words already.
        /// </summary>
        /// <param name="word">Word to add to the queue</param>
        private void AddWordToLastUsedWords(string word)
        {
            if (LastUsedWords.Count == 3)
            {
                LastUsedWords.Dequeue();
            }

            LastUsedWords.Enqueue(word);
        }
    }
}
