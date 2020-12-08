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
        private readonly Queue<Word> _lastUsedWords = new Queue<Word>();
        private int _nrOfLastUsedWordsStored;





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

        private Queue<Word> LastUsedWords
        {
            get => _lastUsedWords;
        }

        private int NrOfLastUsedWordsStored
        {
            get => _nrOfLastUsedWordsStored;

            set
            {
                if (value > 5 || value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "NrOfLastWordsUsed",
                        "NrOfLastWordsUsed must be in the range 0 - 5.");
                }

                _nrOfLastUsedWordsStored = value;
            }
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
            
            InitializeNrOfLastUsedWordsStored();
            InitializeForm();
        }

        private void InitializeForm()
        {
            GetNextWord();
            InitializeGUI();
            StartPractice();
        }

        private void InitializeGUI()
        {
            InitializeDescription();
            UpdateGUIAccordingToCurrentWord();
            lblCorrectOrWrong.Text = "";
        }

        private void InitializeDescription()
        {
            lblDescription.Text = $"Words from { Vocabulary.Name }";
        }






        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void InitializeNrOfLastUsedWordsStored()
        {
            if (Vocabulary == null)
            {
                throw new InvalidOperationException(
                    "The Vocabulary property must be initialized before calling this method.");
            }

            if (Vocabulary.NrOfWords == 1)
            {
                _nrOfLastUsedWordsStored = 0;
            }
            else if (Vocabulary.NrOfWords < 4)
            {
                _nrOfLastUsedWordsStored = 1;
            }
            else if (Vocabulary.NrOfWords < 6)
            {
                _nrOfLastUsedWordsStored = 2;
            }
            else
            {
                _nrOfLastUsedWordsStored = 3;
            }
        }

        private void GetNextWord()
        {
            CurrentWord = Vocabulary.GenerateWeightedRandomWord();

            while (LastUsedWords.Contains(CurrentWord))
            {
                CurrentWord = Vocabulary.GenerateWeightedRandomWord();
                LastUsedWords.Enqueue(CurrentWord);
            }

            while (NrOfLastUsedWordsStored < LastUsedWords.Count)
            {
                LastUsedWords.Dequeue();
            }
        }

        private void UpdateGUIAccordingToCurrentWord()
        {
            SetLabelForOriginalWord();
            InitializeSentenceSection();
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

        private void InitializeSentenceSection()
        {
            // Check for when sentence should not be displayed
            if (PromptWithOriginalLanguage == false
                || String.IsNullOrWhiteSpace(CurrentWord.Sentence))
            {
                // Hide entire sentence section
                lblToggleSentence.Visible = false;
                lblWordUsedInSentence.Visible = false;
                return;
            }
            else
            {
                SetSentence();
                ToggleSentence(false);
                lblToggleSentence.Visible = true;
                lblWordUsedInSentence.Visible = false;
            }
        }

        private void SetSentence()
        {
            lblWordUsedInSentence.Text = CurrentWord.Sentence;
        }

        private void ToggleSentence(bool visible)
        {
            if (visible)
            {
                lblToggleSentence.Text = $"Hide sentence";
            }
            else
            {
                lblToggleSentence.Text = $"Show '{ CurrentWord.OriginalWord }' used in a sentence";
            }

            lblWordUsedInSentence.Visible = visible;
        }

        private void ToggleSentence()
        {
            ToggleSentence(!lblWordUsedInSentence.Visible);
        }

        private void StartPractice()
        {
            if (UseLimitedAmountOfWords)
            {
                RunPracticeWithLimitedAmountOfWords();
            }
            else
            {
                RunPracticeTillUserStops();
            }
        }

        private void RunPracticeWithLimitedAmountOfWords()
        {

        }

        private void RunPracticeTillUserStops()
        {

        }


        

        

        





        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void lblToggleShowSentence_Click(object sender, EventArgs e)
        {
            ToggleSentence();
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

        private void textBoxTranslation_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte charNumber = (byte)e.KeyChar;

            // Enter-key
            if (charNumber == 13)
            {
                // Check if translation is correct

            }
        }
    }
}
