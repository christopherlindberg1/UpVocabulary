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
    public partial class FormCreateAndEdit : Form
    {
        private Vocabulary _vocabulary;

        private readonly InputValidator _inputValidator = new InputValidator();




        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private InputValidator InputValidator
        {
            get => _inputValidator;
        }






        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormCreateAndEdit()
            : this(null)
        {
        }

        public FormCreateAndEdit(Vocabulary vocabulary)
        {
            InitializeComponent();

            InitializeGUI(vocabulary);
        }


        private void InitializeGUI(Vocabulary vocabulary)
        {
            FillLanguageMenusWithData();

            if (vocabulary == null)
            {
                this.Text = "UpVocabulary - Create new Vocabulary";
                lblHeading.Text = "Create new vocabulary";
                lblWordTitle.Text = "Add word";
            }
            else
            {
                this.Text = "UpVocabulary - Edit Vocabulary";
                lblWordTitle.Text = "Edit word";
                lblHeading.Text = "Edit vocabulary";

                InitializeGUIWithVocabularyData(vocabulary);
            }
        }

        private void FillLanguageMenusWithData()
        {
            string[] languages = Enum.GetNames(typeof(Languages));

            comboBoxLanguage1.Items.AddRange(languages);
            comboBoxLanguage2.Items.AddRange(languages);
        }

        private void InitializeGUIWithVocabularyData(Vocabulary vocabulary)
        {
            textBoxNameOfVocabulary.Text = vocabulary.Name;
            AddWordsToGUIList(vocabulary);
            SetLanguagesInGUI(vocabulary);
        }

        private void AddWordsToGUIList(Vocabulary vocabulary)
        {
            listBoxWords.Items.Clear();
            
            listBoxWords.Items.AddRange(vocabulary.GetWordsWithTranslation());
        }

        private void SetLanguagesInGUI(Vocabulary vocabulary)
        {
            comboBoxLanguage1.SelectedItem = vocabulary.OriginalLanguage;
            comboBoxLanguage2.SelectedItem = vocabulary.TranslationLanguage;
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private bool ValidateVocabularyData()
        {
            bool vocabularyNameOk = ValidateVocabularyName();
            bool vocabularyLanguagesOk = ValidateLanguages();
            bool validateWordsExist = ValidateWordsExist();

            return vocabularyNameOk && vocabularyLanguagesOk && validateWordsExist;
        }

        private bool ValidateVocabularyName()
        {
            bool nameOk = InputValidator.ValidateTextBoxString(
                this.textBoxNameOfVocabulary, "The vocabulary must have a name.");

            return nameOk;
        }

        private bool ValidateLanguages()
        {
            bool languagesAreChosen = ValidateLanguagesAreChosen();
            bool languagesAreNotTheSame = ValidateLanguagesAreNotTheSame();

            return languagesAreChosen && languagesAreNotTheSame;
        }

        private bool ValidateLanguagesAreChosen()
        {
            bool language1Ok = InputValidator.ValidateComboBoxItemIsSelected(
                this.comboBoxLanguage1, "You must select a first language.");

            bool language2Ok = InputValidator.ValidateComboBoxItemIsSelected(
                this.comboBoxLanguage2, "You must select a second language.");

            return language1Ok && language2Ok;
        }

        private bool ValidateLanguagesAreNotTheSame()
        {
            if (this.comboBoxLanguage1.SelectedIndex
                == this.comboBoxLanguage2.SelectedIndex
                && this.comboBoxLanguage1.SelectedIndex != -1)
            {
                InputValidator.AddMessage("You must have two different languages");
                return false;
            }
         
            return true;
        }

        private bool ValidateWordsExist()
        {
            if (this.listBoxWords.Items.Count == 0)
            {
                InputValidator.AddMessage("You must have at least one word.");
                return false;
            }

            return true;
        }

        private bool ValidateWordData()
        {
            bool wordOriginalLanguageOk = ValidateWordOriginalLanguage();
            bool wordTranslationOk = ValidateWordTranslation();

            return wordOriginalLanguageOk && wordTranslationOk;
        }

        private bool ValidateWordOriginalLanguage()
        {
            bool wordOk = InputValidator.ValidateTextBoxString(
                this.textBoxWordInLanguage1, "Word cannot be empty");

            return wordOk;
        }

        private bool ValidateWordTranslation()
        {
            bool translationOk = InputValidator.ValidateTextBoxString(
                this.textBoxTranslationToLanguage2, "Translation cannot be empty");

            return translationOk;
        }

        






        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            bool wordData = ValidateWordData();

            if (wordData == false)
            {
                MessageBox.Show(
                    InputValidator.GetMessages(),
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("yaaas");
            }
        }

        private void btnSaveVocabulary_Click(object sender, EventArgs e)
        {
            bool vocabularyDataOk = ValidateVocabularyData();

            if (vocabularyDataOk == false)
            {
                MessageBox.Show(
                    InputValidator.GetMessages(),
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("yaaas");
            }
        }
    }
}
