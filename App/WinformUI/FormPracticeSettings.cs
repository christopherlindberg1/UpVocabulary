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
    public partial class FormPracticeSettings : Form
    {
        private readonly InputValidator _inputValidator = new InputValidator();
        private Vocabulary _vocabularyToPracticeWith;
        private int _nrOfWordsToPracticeWith = 0;
        private bool _promptWithOriginalLanguage;
        private bool _useLimitedAmountOfWords;





        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private InputValidator InputValidator
        {
            get => _inputValidator;
        }

        private Vocabulary VocabularyToPracticeWith
        {
            get => _vocabularyToPracticeWith;

            set
            {
                _vocabularyToPracticeWith = value ??
                    throw new ArgumentNullException(
                        "VocabularyToPracticeWith",
                        "VocabularyToPracticeWith cannot be null.");
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





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormPracticeSettings(Vocabulary vocabularyToPracticeWith)
        {
            InitializeComponent();

            VocabularyToPracticeWith = vocabularyToPracticeWith;

            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            InitializeFormDescription();
            InitializeLanguageMenu();
            InitializeNrOfWordsMenu();
        }

        private void InitializeFormDescription()
        {
            lblDescription.Text =
                $"Configure your practice session for { VocabularyToPracticeWith.Name }";
        }

        private void InitializeLanguageMenu()
        {
            string originalLanguage = VocabularyToPracticeWith.OriginalLanguage;
            string translationLanguage = VocabularyToPracticeWith.TranslationLanguage;

            comboBoxLanguages.Items.Add($"{ originalLanguage } to { translationLanguage }");
            comboBoxLanguages.Items.Add($"{ translationLanguage } to { originalLanguage }");
        }

        private void InitializeNrOfWordsMenu()
        {
            int[] choices = (int[])Enum.GetValues(typeof(NrOfWordsToPracticeWith));

            for (int i = 0; i < choices.Length; i++)
            {
                if (choices[i] > VocabularyToPracticeWith.NrOfWords)
                {
                    break;
                }

                comboBoxNrOfWords.Items.Add(choices[i]);
            }

            comboBoxNrOfWords.Items.Add("No limit");
        }






        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private bool ValidateInput()
        {
            bool languagesOk = ValidateLanguagesChoice();
            bool nrOfWordsOk = ValidateNrOfWordsChoice();

            return languagesOk && nrOfWordsOk;
        }

        private bool ValidateLanguagesChoice()
        {
            return InputValidator.ValidateComboBoxItemIsSelected(
                comboBoxLanguages,
                "You must choose a language setting.");
        }

        private bool ValidateNrOfWordsChoice()
        {
            return InputValidator.ValidateComboBoxItemIsSelected(
                comboBoxNrOfWords,
                "You must choose an amount of words to practice with.");
        }

        private void SavePracticeSettings()
        {
            SaveLanguageSettings();
            SaveNrOfWordsToPracticeWith();
        }

        private void SaveLanguageSettings()
        {
            if (comboBoxLanguages.SelectedIndex == 0)
            {
                PromptWithOriginalLanguage = true;
            }
            else if (comboBoxLanguages.SelectedIndex == 1)
            {
                PromptWithOriginalLanguage = false;
            }
        }

        private void SaveNrOfWordsToPracticeWith()
        {
            string selectedValue = comboBoxNrOfWords.SelectedItem.ToString();
            if (selectedValue.Equals("No limit"))
            {
                UseLimitedAmountOfWords = false;
            }
            else
            {
                UseLimitedAmountOfWords = true;
                NrOfWordsToPracticeWith = int.Parse(selectedValue);
            }
        }





        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void btnStartPractice_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == false)
            {
                MessageBox.Show(
                    InputValidator.GetMessages(),
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            else
            {
                SavePracticeSettings();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
