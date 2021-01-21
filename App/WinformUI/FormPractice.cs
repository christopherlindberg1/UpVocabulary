using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppFeatures;

namespace WinformUI
{
    public partial class FormPractice : Form
    {
        /**
         * App settings passed in from Main form
         */
        private AppSettings _appSettings;

        /**
         * fields needed to set up the form before practice
         */
        private readonly InputValidator _inputValidator = new InputValidator();
        private Vocabulary _vocabulary;
        private string _originalLanguage;
        private string _translationLanguage;
        private int _nrOfWordsToPracticeWith;
        private bool _promptWithOriginalLanguage;
        private bool _useLimitedAmountOfWords;

        /**
         * fields used to keep track of a practice session. 
         */
        private Word _currentWord;
        private readonly Queue<Word> _lastUsedWords = new Queue<Word>();
        private readonly List<PracticeWord> _askedWords = new List<PracticeWord>();
        private int _nrOfLastUsedWordsToStore;
        private int _nrOfQuestionsAsked;
        private bool _currentlyHandlingQuestion;
        private readonly Dictionary<string, int> _score = new Dictionary<string, int>
        { 
            {"correct", 0 },
            {"wrong", 0 }
        };
        //private readonly Dictionary<Word, bool> _results = new Dictionary<Word, bool>();
        private bool _practiceIsDone;




        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private AppSettings AppSettings
        {
            get => _appSettings;

            set => _appSettings = value ??
                throw new ArgumentNullException(
                        "AppSettings",
                        "AppSettings cannot be null.");
        }

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

        private List<PracticeWord> AskedWords
        {
            get => _askedWords;
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

        private bool CurrentlyHandlingQuestion
        {
            get => _currentlyHandlingQuestion;

            set => _currentlyHandlingQuestion = value;
        }

        private Dictionary<string, int> Score
        {
            get => _score;
        }

        private bool PracticeIsDone
        {
            get => _practiceIsDone;

            set => _practiceIsDone = value;
        }





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormPractice(
            AppSettings appSettings,
            Vocabulary vocabulary,
            int nrOfWordsToPracticeWith,
            bool promptWithOriginalLanguage,
            bool useLimitedAmountOfWords)
        {
            InitializeComponent();

            Vocabulary = vocabulary;
            AppSettings = appSettings;
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
            SetTextsAccordingToAppLanguage();
            //InitializeDescription();
            InitializeCorrectOrWrong();
            ToggleBtnNextWord(false);
            InitializeResultsSection();
            btnPracticeAgain.Visible = false;
        }

        private void SetTextsAccordingToAppLanguage()
        {
            if (AppSettings == null)
            {
                throw new InvalidOperationException("Cannot call this method is AppSettings is null");
            }

            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                SetTextsToEnglish();
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                SetTextsToSwedish();
            }
        }

        private void SetTextsToEnglish()
        {
            this.Text = FormPracticeTexts.GetFormTitle_TextInEnglish();

            lblHeading.Text = FormPracticeTexts.GetLblHeading_TextInEnglish(Vocabulary.Name);
            lblTranslation.Text = FormPracticeTexts.GetLblTranslation_TextInEnglish();
            lblToggleScore.Text = FormPracticeTexts.GetLblToggleScore_Hide_TextInEnglish();
            lblScore.Text = FormPracticeTexts.GetLblScore_TextInEnglish();

            btnSubmitTranslation.Text = FormPracticeTexts.GetBtnSubmitTranslation_TextInEnglish();
            btnGetNextWord.Text = FormPracticeTexts.GetBtnGetNextWord_TextInEnglish();
            btnEndPractice.Text = FormPracticeTexts.GetBtnEndPractice_TextInEnglish();
            btnPracticeAgain.Text = FormPracticeTexts.GetBtnPracticeAgain_TextInEnglish();

            lblResults.Text = FormPracticeTexts.GetLblResults_TextInEnglish();
            
            UpdateScoreInGUI();
        }

        private void SetTextsToSwedish()
        {
            this.Text = FormPracticeTexts.GetFormTitle_TextInSwedish();

            lblHeading.Text = FormPracticeTexts.GetLblHeading_TextInSwedish(Vocabulary.Name);
            lblTranslation.Text = FormPracticeTexts.GetLblTranslation_TextInSwedish();
            lblToggleScore.Text = FormPracticeTexts.GetLblToggleScore_Hide_TextInSwedish();
            lblScore.Text = FormPracticeTexts.GetLblScore_TextInSwedish();

            btnSubmitTranslation.Text = FormPracticeTexts.GetBtnSubmitTranslation_TextInSwedish();
            btnGetNextWord.Text = FormPracticeTexts.GetBtnGetNextWord_TextInSwedish();
            btnEndPractice.Text = FormPracticeTexts.GetBtnEndPractice_TextInSwedish();
            btnPracticeAgain.Text = FormPracticeTexts.GetBtnPracticeAgain_TextInSwedish();

            lblResults.Text = FormPracticeTexts.GetLblResults_TextInSwedish();

            UpdateScoreInGUI();
        }

        private void InitializeCorrectOrWrong()
        {
            lblCorrectOrWrong.Text = "";
            lblCorrectTranslation.Text = "";
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

        private void InitializeResultsSection()
        {
            ToggleResultsSection(false);
            lblResults.Location = new Point(22, 170);
            listBoxResults.Location = new Point(24, 193);
            listBoxResults.Size = new Size(651, 256);
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
            lblCorrectTranslation.Text = "";
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

            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                lblWordToTranslate.Text =
                    FormPracticeTexts.GetLblWordToTranslate_TextInEnglish(
                        wordToTranslate, translationLanguage);
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                lblWordToTranslate.Text =
                    FormPracticeTexts.GetLblWordToTranslate_TextInSwedish(
                        wordToTranslate, translationLanguage);
            }
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
            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                if (visible)
                {
                    lblToggleSentence.Text = FormPracticeTexts.GetLblToggleSentence_Hide_TextInEnglish();
                }
                else
                {
                    lblToggleSentence.Text =
                        FormPracticeTexts.GetLblToggleSentence_Show_TextInEnglish(
                            CurrentWord.OriginalWord);
                }
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                if (visible)
                {
                    lblToggleSentence.Text = FormPracticeTexts.GetLblToggleSentence_Hide_TextInSwedish();
                }
                else
                {
                    lblToggleSentence.Text =
                        FormPracticeTexts.GetLblToggleSentence_Show_TextInSwedish(
                            CurrentWord.OriginalWord);
                }
            }
            
            lblWordUsedInSentence.Visible = visible;
        }

        private void ToggleSentence()
        {
            ToggleSentence(!lblWordUsedInSentence.Visible);
        }

        private void ToggleBtnNextWord(bool visible)
        {
            btnGetNextWord.Visible = visible;
        }

        private void TogglePracticeElements(bool visible)
        {
            lblWordToTranslate.Visible = visible;
            lblToggleSentence.Visible = visible;
            lblWordUsedInSentence.Visible = visible;
            lblTranslation.Visible = visible;
            textBoxTranslation.Visible = visible;
            btnSubmitTranslation.Visible = visible;
            lblCorrectOrWrong.Visible = visible;
            lblCorrectTranslation.Visible = visible;
        }

        private void StartPractice()
        {
            PracticeIsDone = false;
            AskNextQuestion();
        }

        private void AskNextQuestion()
        {
            _currentlyHandlingQuestion = false;
            GetNextWord();
            UpdateGUIToNextWord();
        }

        private async void HandleAnswer()
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

            CurrentlyHandlingQuestion = true;
            PracticeWord practiceWord = null;
            
            bool correctTranslation = CheckTranslation();

            if (correctTranslation)
            {
                ShowAnswerIsCorrect();
                Vocabulary.UpdateWeightOfWord(CurrentWord, true);
                UpdateScore(true);
                practiceWord = new PracticeWord(CurrentWord, textBoxTranslation.Text.ToLower(), true);
            }
            else
            {
                ShowAnswerIsWrong();
                Vocabulary.UpdateWeightOfWord(CurrentWord, false);
                UpdateScore(false);
                practiceWord = new PracticeWord(CurrentWord, textBoxTranslation.Text.ToLower(), false);
            }

            AskedWords.Add(practiceWord);

            NrOfQuestionsAsked++;

            // True when practice session is not done.
            if (UseLimitedAmountOfWords == false
                || NrOfQuestionsAsked < NrOfWordsToPracticeWith)
            {
                // If user gave correct translation, Wait before asking next word
                if (correctTranslation)
                {
                    if (AppSettings.AutoPromptQuestionAfterCorrectAnswer)
                    {
                        await Task.Delay(AppSettings.DelayBeforePromptingNextQuestionAfterCorrectAnswer);
                        AskNextQuestion();
                    }
                    else
                    {
                        ToggleBtnNextWord(true);
                    }

                }
                // If user gave incorrect translation, let user click btn to get next word
                else
                {
                    if (AppSettings.AutoPromptQuestionAfterIncorrectAnswer)
                    {
                        await Task.Delay(AppSettings.DelayBeforePromptingNextQuestionAfterIncorrectAnswer);
                        AskNextQuestion();
                    }
                    else
                    {
                        ToggleBtnNextWord(true);
                    }
                }
            }
            // True when practice session is done.
            else
            {
                PracticeIsDone = true;
                await Task.Delay(1500);
                ShowResults();
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
            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                lblCorrectOrWrong.Text = FormPracticeTexts.GetLblCorrectOrWrong_Correct_TextInEnglish();
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                lblCorrectOrWrong.Text = FormPracticeTexts.GetLblCorrectOrWrong_Correct_TextInSwedish();
            }

            lblCorrectOrWrong.BackColor = Color.Green;
            lblCorrectOrWrong.ForeColor = Color.White;
            lblCorrectOrWrong.Visible = true;
            lblCorrectOrWrong.Refresh();
            lblCorrectTranslation.Text = "";
        }

        private void ShowAnswerIsWrong()
        {
            string correctAnswer = (PromptWithOriginalLanguage == true)
                ? CurrentWord.Translation : CurrentWord.OriginalWord;

            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                lblCorrectOrWrong.Text = FormPracticeTexts.GetLblCorrectOrWrong_Wrong_TextInEnglish();
                lblCorrectTranslation.Text =
                    FormPracticeTexts.GetLblCorrectTranslation_TextInEnglish(correctAnswer);
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                lblCorrectOrWrong.Text = FormPracticeTexts.GetLblCorrectOrWrong_Wrong_TextInSwedish();
                lblCorrectTranslation.Text =
                    FormPracticeTexts.GetLblCorrectTranslation_TextInSwedish(correctAnswer);
            }

            lblCorrectOrWrong.BackColor = Color.Red;
            lblCorrectOrWrong.ForeColor = Color.White;
            lblCorrectOrWrong.Visible = true;
        }

        private void ToggleScore()
        {

            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                if (groupBoxScore.Visible)
                {
                    lblToggleScore.Text = FormPracticeTexts.GetLblToggleScore_Show_TextInEnglish();
                }
                else
                {
                    lblToggleScore.Text = FormPracticeTexts.GetLblToggleScore_Hide_TextInEnglish();
                }
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                if (groupBoxScore.Visible)
                {
                    lblToggleScore.Text = FormPracticeTexts.GetLblToggleScore_Show_TextInSwedish();
                }
                else
                {
                    lblToggleScore.Text = FormPracticeTexts.GetLblToggleScore_Hide_TextInSwedish();
                }
            }

            groupBoxScore.Visible = !groupBoxScore.Visible;
        }

        private void ShowScore()
        {
            groupBoxScore.Visible = true;

            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                lblToggleScore.Text = FormPracticeTexts.GetLblToggleScore_Hide_TextInEnglish();
            }
            else if (AppSettings.AppLanguage == AppLanguages.English)
            {
                lblToggleScore.Text = FormPracticeTexts.GetLblToggleScore_Hide_TextInSwedish();
            }

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
            string correctAnswers = Score["correct"].ToString();
            string totalAmountOfAnswers = (Score["correct"] + Score["wrong"]).ToString();

            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                lblNrOfCorrectAnswers.Text = FormPracticeTexts.GetLblNrOfCorrectAnswers_TextInEnglish(
                    correctAnswers,
                    totalAmountOfAnswers);
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                lblNrOfCorrectAnswers.Text = FormPracticeTexts.GetLblNrOfCorrectAnswers_TextInSwedish(
                    correctAnswers,
                    totalAmountOfAnswers);
            }
        }

        private void ShowResults()
        {
            // Prepare GUI to show results
            ShowScore();
            lblHeading.Focus();
            FillResultsList();
            TogglePracticeElements(false);
            //btnPracticeAgain.Visible = true;

            // Show results
            ToggleResultsSection(true);
        }

        private void FillResultsList()
        {
            listBoxResults.Items.Clear();

            for (int i = 0; i < AskedWords.Count; i++)
            {
                string promptedWord;
                string translation = AskedWords[i].UserTranslation;
                string result;

                if (PromptWithOriginalLanguage)
                {
                    promptedWord = AskedWords[i].Word.OriginalWord;
                }
                else
                {
                    promptedWord = AskedWords[i].Word.Translation;
                }

                if (AskedWords[i].CorrectTranslation)
                {
                    result = "Correct";
                }
                else
                {
                    if (PromptWithOriginalLanguage)
                    {
                        result = $"Wrong (correct translation is '{ AskedWords[i].Word.Translation }')";
                    }
                    else
                    {
                        result = $"Wrong (correct translation is '{ AskedWords[i].Word.OriginalWord }')";
                    }
                }
            
                string resultLine = $"{ i + 1 }: { promptedWord } - { translation } --- { result }";
                listBoxResults.Items.Add(resultLine);
            }
        }

        private void ToggleResultsSection(bool visible)
        {
            lblResults.Visible = visible;
            listBoxResults.Visible = visible;
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
            ToggleScore();
        }

        private void textBoxTranslation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CurrentlyHandlingQuestion == false)
            {
                // Enter-key
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // Check if translation is correct
                    HandleAnswer();
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (CurrentlyHandlingQuestion == false)
            {
                HandleAnswer();
            }
        }

        private void btnGetNextWord_Click(object sender, EventArgs e)
        {
            AskNextQuestion();
            ToggleBtnNextWord(false);
            textBoxTranslation.Focus();
        }

        private void btnEndPractice_Click(object sender, EventArgs e)
        {
            if (PracticeIsDone == false)
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
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPracticeAgain_Click(object sender, EventArgs e)
        {

        }
    }
}
