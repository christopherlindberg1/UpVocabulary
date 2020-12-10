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
        private int _nrOfLastUsedWordsToStore;
        private int _nrOfQuestionsAsked;
        private readonly Dictionary<string, int> _score = new Dictionary<string, int>
        { 
            {"correct", 0 },
            {"wrong", 0 }
        };





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
                    "CurrentWord",
                    "CurrentWord cannot be null");
        }

        private Queue<Word> LastUsedWords
        {
            get => _lastUsedWords;
        }

        private int NrOfLastUsedWordsToStore
        {
            get => _nrOfLastUsedWordsToStore;

            set
            {
                if (value > 5 || value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "NrOfLastUsedWordsStored",
                        "NrOfLastUsedWordsStored must be in the range 0 - 5.");
                }

                _nrOfLastUsedWordsToStore = value;
            }
        }

        private int NrOfQuestionsAsked
        {
            get => _nrOfQuestionsAsked;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "NrOfQuestionsAsked",
                        "NrOfQuestionsAsked cennot be less than 0.");
                }

                _nrOfQuestionsAsked = value;
            }
        }

        private Dictionary<string, int> Score
        {
            get => _score;
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
            NrOfQuestionsAsked = 0;
            
            InitializeNrOfLastUsedWordsStored();
            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeGUI();
            StartPractice();
        }

        private void InitializeGUI()
        {
            InitializeDescription();
            InitializeCorrectOrWrong();
        }

        private void InitializeDescription()
        {
            lblDescription.Text = $"Words from { Vocabulary.Name }";
        }

        private void InitializeCorrectOrWrong()
        {
            lblCorrectOrWrong.Text = "";
            lblCorrectAnswer.Text = "";
            lblCorrectOrWrong.ForeColor = Color.White;
        }

        private void InitializeNrOfLastUsedWordsStored()
        {
            if (Vocabulary == null)
            {
                throw new InvalidOperationException(
                    "The Vocabulary property must be initialized before calling this method.");
            }

            if (Vocabulary.NrOfWords == 1)
            {
                NrOfLastUsedWordsToStore = 0;
            }
            else if (Vocabulary.NrOfWords < 4)
            {
                NrOfLastUsedWordsToStore = 1;
            }
            else if (Vocabulary.NrOfWords < 6)
            {
                NrOfLastUsedWordsToStore = 2;
            }
            else
            {
                NrOfLastUsedWordsToStore = 3;
            }
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void UpdateGUIToNextWord()
        {
            SetLabelForOriginalWord();
            UpdateSentenceSection();
            textBoxTranslation.Text = "";
            lblCorrectOrWrong.Text = "";
            lblCorrectOrWrong.Visible = false;
            lblCorrectAnswer.Text = "";
        }

        private void GetNextWord()
        {
            CurrentWord = Vocabulary.GenerateWeightedRandomWord();

            // Make sure next word is not one of the last used ones
            while (LastUsedWords.Contains(CurrentWord))
            {
                CurrentWord = Vocabulary.GenerateWeightedRandomWord();
            }

            LastUsedWords.Enqueue(CurrentWord);

            //StringBuilder sb = new StringBuilder();

            //sb.Append($"LastUsedWords.Count: { LastUsedWords.Count }\n");
            //sb.Append($"LastUsedWords.Count: { LastUsedWords.Peek().ToString() }\n");

            //MessageBox.Show(sb.ToString());

            // Dequeue last used words if there are more than what should be kept track of
            while (LastUsedWords.Count > NrOfLastUsedWordsToStore)
            {
                LastUsedWords.Dequeue();
            }
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

        private void UpdateSentenceSection()
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
            AskNextQuestion();
        }

        private void AskNextQuestion()
        {
            GetNextWord();
            UpdateGUIToNextWord();
        }

        private void HandleAnswer()
        {
            // Check that there is an answer, abort otherwise
            if (ValidateAnswerInputExists() == false)
            {
                MessageBox.Show(
                    InputValidator.GetMessages(),
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (CheckTranslation())
            {
                ShowAnswerIsCorrect();
                Vocabulary.UpdateWeightOfWord(CurrentWord, true);
                UpdateScore(true);
            }
            else
            {
                ShowAnswerIsWrong();
                Vocabulary.UpdateWeightOfWord(CurrentWord, false);
                UpdateScore(false);
            }

            // Delay execution for a while

            // Update score



            StringBuilder sb = new StringBuilder();
            sb.Append($"Current word: { CurrentWord }\n");
            sb.Append($"Weight: { CurrentWord.Weight }\n");
            sb.Append($"Times answered correctly: { CurrentWord.TimesAnsweredCorrectly}\n");

            MessageBox.Show(sb.ToString());

            NrOfQuestionsAsked++;

            if (UseLimitedAmountOfWords == false
                || NrOfQuestionsAsked < NrOfWordsToPracticeWith)
            {
                AskNextQuestion();
            }
            else
            {
                // Stop practice
                return;
            }
        }

        private bool ValidateAnswerInputExists()
        {
            if (String.IsNullOrWhiteSpace(textBoxTranslation.Text))
            {
                InputValidator.AddMessage("You must provide a translation");
                return false;
            }

            return true;
        }

        private bool CheckTranslation()
        {
            string userTranslation = textBoxTranslation.Text.ToLower();

            if (PromptWithOriginalLanguage)
            {
                if (userTranslation.Equals(CurrentWord.Translation.ToLower()))
                {
                    return true;
                }
            }
            else
            {
                if (userTranslation.Equals(CurrentWord.OriginalWord.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }

        private void ShowAnswerIsCorrect()
        {
            lblCorrectOrWrong.Text = "Correct";
            lblCorrectOrWrong.BackColor = Color.Green;
            lblCorrectOrWrong.ForeColor = Color.White;
            lblCorrectOrWrong.Visible = true;
            lblCorrectOrWrong.Refresh();
            lblCorrectAnswer.Text = "";
        }

        private void ShowAnswerIsWrong()
        {
            string correctAnswer = (PromptWithOriginalLanguage == true)
                ? CurrentWord.Translation : CurrentWord.OriginalWord;

            lblCorrectOrWrong.Text = "Wrong";
            lblCorrectOrWrong.BackColor = Color.Red;
            lblCorrectOrWrong.ForeColor = Color.White;
            lblCorrectOrWrong.Visible = true;
            lblCorrectAnswer.Text = $"The correct translation is '{ correctAnswer }'";
        }

        private void UpdateScore(bool userAnsweredCorrenctly)
        {
            if (userAnsweredCorrenctly)
            {
                Score["correct"]++;
            }
            else
            {
                Score["wrong"]++;
            }

            UpdateScoreInGUI();
        }

        private void UpdateScoreInGUI()
        {
            lblNrOfCorrectAnswers.Text =
                $"{ Score["correct"] } / { Score["correct"] + Score["wrong"] } correct";
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
            // Enter-key
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Check if translation is correct
                HandleAnswer();
                e.Handled = true;
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            HandleAnswer();
        }

        private void btnEndPractice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Sure you want to quit your practice session?",
                "Info",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormPractice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Vocabulary.UpdateDateLastUsed();
        }
    }
}
