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
        private Word _currentWord;
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

        private string OriginalLanguage
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

        private string TranslationLanguage
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

        private int NrOfWordsToPracticeWith
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

        private bool PromptWithOriginalLanguage
        {
            get => _promptWithOriginalLanguage;

            set => _promptWithOriginalLanguage = value;
        }

        private bool UseLimitedAmountOfWords
        {
            get => _useLimitedAmountOfWords;

            set => _useLimitedAmountOfWords = value;
        }

        private Word CurrentWord
        {
            get => _currentWord;

            set => _currentWord = value ??
                throw new ArgumentNullException(
                    "Current word",
                    "Current word cannot be null");
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
            int nrOfWordsToPracticeWith,
            bool promptWithOriginalLanguage,
            bool useLimitedAmountOfWords)
        {
            InitializeComponent();

            Vocabulary = vocabulary;
            OriginalLanguage = Vocabulary.OriginalLanguage;
            TranslationLanguage = Vocabulary.TranslationLanguage;
            NrOfWordsToPracticeWith = nrOfWordsToPracticeWith;
            PromptWithOriginalLanguage = promptWithOriginalLanguage;
            UseLimitedAmountOfWords = useLimitedAmountOfWords;

            InitializeForm();
        }

        private void InitializeForm()
        {
            GetFirstWord();
            InitializeGUI();
            StartPractice();
        }

        private void InitializeGUI()
        {
            InitializeDescription();
            UpdateGUIAccordingToCurrentWord();
            ToggleSentenceUsingWord(false);
        }

        private void InitializeDescription()
        {
            lblDescription.Text = $"Words from { Vocabulary.Name }";
        }

        private void GetFirstWord()
        {
            CurrentWord = Vocabulary.GenerateWeightedRandomWord();
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void UpdateGUIAccordingToCurrentWord()
        {
            SetLabelForOriginalWord();
            SetLabelForTogglingSentence();
            SetLabelForWordUsedInSentence();
        }

        private void SetLabelForOriginalWord()
        {
            string wordToTranslate = null;
            string translationLanguage = null;

            if (PromptWithOriginalLanguage)
            {
                wordToTranslate = CurrentWord.OriginalWord;
                translationLanguage = TranslationLanguage;
            }
            else
            {
                wordToTranslate = CurrentWord.Translation;
                translationLanguage = OriginalLanguage;
            }

            lblWordToTranslate.Text = $"Translate '{ wordToTranslate }' to { translationLanguage }";
        }

        private void SetLabelForTogglingSentence()
        {
            string wordToTranslate = null;

            if (PromptWithOriginalLanguage)
            {
                wordToTranslate = CurrentWord.OriginalWord;
            }
            else
            {
                wordToTranslate = CurrentWord.Translation;
            }

            lblToggleShowSentence.Text = $"Show '{ wordToTranslate }' used in a sentence";
        }

        private void ToggleSentenceUsingWord(bool visible)
        {
            lblWordUsedInSentence.Visible = visible;
        }

        private void SetLabelForWordUsedInSentence()
        {
            lblWordUsedInSentence.Text = CurrentWord.Sentence;
        }

        private void StartPractice()
        {
            

            if (UseLimitedAmountOfWords)
            {

            }

            // Generate next for to practice
            while (LastUsedWordsContains(CurrentWord.OriginalWord))
            {
                CurrentWord = Vocabulary.GenerateWeightedRandomWord();
            }
        }


        

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





        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void lblToggleShowSentence_Click(object sender, EventArgs e)
        {
            if (lblWordUsedInSentence.Visible)
            {
                // text - show
            }
            else
            {
                // text - hide
            }

            lblWordUsedInSentence.Visible = !lblWordUsedInSentence.Visible;
        }

        private void lblToggleScore_Click(object sender, EventArgs e)
        {
            if (groupBoxScore.Visible)
            {
                lblToggleScore.Text = "Show score";
            }
            else
            {
                lblToggleScore.Text = "Hide score";
            }

            groupBoxScore.Visible = !groupBoxScore.Visible;
        }
    }
}
