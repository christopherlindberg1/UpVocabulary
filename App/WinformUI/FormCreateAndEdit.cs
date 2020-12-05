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
        private DialogResult _saveVocabulary;
        private Vocabulary _vocabulary;
        private readonly InputValidator _inputValidator = new InputValidator();




        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        public DialogResult SaveVocabulary
        {
            get => _saveVocabulary;

            set
            {
                if (value != DialogResult.Yes && value != DialogResult.Cancel)
                {
                    throw new ArgumentException("Dialog result must be 'Yes' or 'Cancel'", "SaveVocabulary");
                }
                else
                {
                    _saveVocabulary = value;
                }
            }
        }

        private Vocabulary Vocabulary
        {
            get => _vocabulary;

            set
            {
                _vocabulary = value ?? throw new ArgumentNullException(
                    "Vocabulary",
                    "Vocabulary cannot be null.");
            }
        }

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
        {
            InitializeComponent();

            InitializeForm();
        }

        public FormCreateAndEdit(Vocabulary vocabulary)
        {
            InitializeComponent();

            Vocabulary = vocabulary;

            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeGUI();

            // True when user wants to create new vocabulary
            if (Vocabulary == null)
            {
                Vocabulary = new Vocabulary();
            }
        }


        private void InitializeGUI()
        {
            FillLanguageMenusWithData();

            if (Vocabulary == null)
            {
                this.Text = "UpVocabulary - Create new Vocabulary";
                lblHeading.Text = "Create new vocabulary";
                lblWordTitle.Text = "Add word";
            }
            else
            {
                this.Text = "UpVocabulary - Edit Vocabulary";
                lblHeading.Text = "Edit vocabulary";
                lblWordTitle.Text = "Edit word";

                InitializeGUIWithVocabularyData(Vocabulary);
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
            bool wordInOriginalLanguageOk = ValidateWordOriginalLanguage();
            bool wordTranslationOk = ValidateWordTranslation();

            return wordInOriginalLanguageOk && wordTranslationOk;
        }

        private bool ValidateWordOriginalLanguage()
        {
            bool wordOk = InputValidator.ValidateTextBoxString(
                this.textBoxWordInOriginalLanguage, "Word cannot be empty");

            return wordOk;
        }

        private bool ValidateWordTranslation()
        {
            bool translationOk = InputValidator.ValidateTextBoxString(
                this.textBoxWordTranslationToOtherLanguage, "Translation cannot be empty");

            return translationOk;
        }

        private void ClearWordInputFields()
        {
            textBoxWordInOriginalLanguage.Text = "";
            textBoxWordTranslationToOtherLanguage.Text = "";
            textBoxWordUsedInSentence.Text = "";
        }

        private void FillWordInputFields(Word word)
        {
            textBoxWordInOriginalLanguage.Text = word.OriginalWord;
            textBoxWordTranslationToOtherLanguage.Text = word.Translation;
            textBoxWordUsedInSentence.Text = word.Sentence;
        }

        private void SaveWord()
        {
            string originalWord = textBoxWordInOriginalLanguage.Text.ToLower();
            string translation = textBoxWordTranslationToOtherLanguage.Text.ToLower();
            string sentence = textBoxWordUsedInSentence.Text;

            Word newWord = new Word(originalWord, translation, sentence);

            int selectedWordIndex = listBoxWords.SelectedIndex;

            // True when user is adding a new word
            if (selectedWordIndex == -1)
            {
                // Check if word already exists
                if (Vocabulary.WordExists(originalWord))
                {
                    MessageBox.Show(
                        $"The word '{ originalWord }' already exists in this vocabulary.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                { 
                    Vocabulary.InsertWord(newWord);
                }
            }
            // True when user is editing a existing word
            else
            {
                Vocabulary.UpdateWord(Vocabulary.GetWordAt(selectedWordIndex), newWord);
            }

            //MessageBox.Show(Vocabulary.GetWordAt(0).ToString());

            UpdateWordsInGUI();
            ClearWordInputFields();

            listBoxWords.SelectedIndex = -1;
        }

        /// <summary>
        ///   Updates the listbox with words to match the list of words
        ///   in the vocabulary.
        /// </summary>
        private void UpdateWordsInGUI()
        {
            listBoxWords.Items.Clear();
            listBoxWords.Items.AddRange(Vocabulary.GetWordsWithTranslation());
        }

        private void SaveWordToVocabulary(Word word)
        {
            Vocabulary.InsertWord(word);
            throw new NotImplementedException();
        }






        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedWordIndex = listBoxWords.SelectedIndex;
            
            if (selectedWordIndex == -1)
            {
                return;
            }
            
            Word selectedWord = Vocabulary.GetWordAt(selectedWordIndex);
            FillWordInputFields(selectedWord);
        }

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
                SaveWord();
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
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        
    }
}
