﻿using System;
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
        private readonly InputValidator _inputValidator = new InputValidator();
        private Vocabulary _vocabulary;
        private string[] _namesOfAllVocabulaies;
        private bool _editingExistingVocabulary;
        private string _originalVocabularyName;
        private bool _vocabularyHasBeenChanged;



        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private InputValidator InputValidator
        {
            get => _inputValidator;
        }

        public Vocabulary Vocabulary
        {
            get => _vocabulary;

            set
            {
                _vocabulary = value ??
                    throw new ArgumentNullException(
                        "Vocabulary",
                        "Vocabulary cannot be null.");
            }
        }

        public string[] NamesOfAllVocabularies
        {
            get => _namesOfAllVocabulaies;

            set
            {
                _namesOfAllVocabulaies = value ??
                    throw new ArgumentNullException(
                        "NameOfAllVocabularies",
                        "NameOfAllVocabularies cannot be null.");
            }
        }

        private bool EditingExistingVocabulary
        {
            get => _editingExistingVocabulary;

            set => _editingExistingVocabulary = value;
        }

        private string OriginalVocabularyName
        {
            get => _originalVocabularyName;

            set
            {
                _originalVocabularyName = value ??
                    throw new ArgumentNullException(
                        "OriginalVocabularyName",
                        "OriginalVocabularyName cannot be null.");
            }
        }

        private bool VocabularyHasBeenChanged
        {
            get => _vocabularyHasBeenChanged;

            set => _vocabularyHasBeenChanged = value;
        }






        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormCreateAndEdit(string[] namesOfAllVocabularies)
        {
            InitializeComponent();

            NamesOfAllVocabularies = namesOfAllVocabularies;
            EditingExistingVocabulary = false;

            InitializeForm();
        }

        public FormCreateAndEdit(string[] namesOfAllVocabularies, Vocabulary vocabulary)
        {
            InitializeComponent();

            NamesOfAllVocabularies = namesOfAllVocabularies;
            Vocabulary = vocabulary;
            EditingExistingVocabulary = true;
            OriginalVocabularyName = vocabulary.Name;

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
            SetGUIToCreateState();

            if (Vocabulary == null)
            {
                this.Text = "UpVocabulary - Create new Vocabulary";
                lblHeading.Text = "Create new vocabulary";
                //lblWordTitle.Text = "Add word";
            }
            else
            {
                this.Text = "UpVocabulary - Edit Vocabulary";
                lblHeading.Text = "Edit vocabulary";
                //lblWordTitle.Text = "Add word";

                InitializeGUIWithVocabularyData(Vocabulary);
            }
        }

        private void FillLanguageMenusWithData()
        {
            string[] languages = Enum.GetNames(typeof(Languages));

            comboBoxOriginalLanguage.Items.AddRange(languages);
            comboBoxTranslationLanguage.Items.AddRange(languages);
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
            comboBoxOriginalLanguage.SelectedItem = vocabulary.OriginalLanguage;
            comboBoxTranslationLanguage.SelectedItem = vocabulary.TranslationLanguage;
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
            //bool validateWordsExist = ValidateWordsExist();

            return vocabularyNameOk && vocabularyLanguagesOk;
        }

        private bool ValidateVocabularyName()
        {
            bool nameNotUsed = ValidateVocabularyNameCanBeUsed();
            bool nameOk = InputValidator.ValidateTextBoxString(
                this.textBoxNameOfVocabulary, "The vocabulary must have a name.");

            return nameNotUsed && nameOk;
        }

        private bool ValidateVocabularyNameCanBeUsed()
        {
            string name = textBoxNameOfVocabulary.Text;

            // True when editing existing vocabulary
            if (EditingExistingVocabulary == true)
            {
                if (OriginalVocabularyName.Equals(name))
                {
                    return true;
                }
            }

            return VocabularyNameIsAlreadyUsed(name);
        }

        private bool VocabularyNameIsAlreadyUsed(string name)
        {
            for (int i = 0; i < NamesOfAllVocabularies.Length; i++)
            {
                if (NamesOfAllVocabularies[i].Equals(name))
                {
                    InputValidator.AddMessage(
                        $"The name '{ name }' has already been used for another vocaulary");
                    return false;
                }
            }

            return true;
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
                this.comboBoxOriginalLanguage, "You must select a first language.");

            bool language2Ok = InputValidator.ValidateComboBoxItemIsSelected(
                this.comboBoxTranslationLanguage, "You must select a second language.");

            return language1Ok && language2Ok;
        }

        private bool ValidateLanguagesAreNotTheSame()
        {
            if (this.comboBoxOriginalLanguage.SelectedIndex
                == this.comboBoxTranslationLanguage.SelectedIndex
                && this.comboBoxOriginalLanguage.SelectedIndex != -1)
            {
                InputValidator.AddMessage("You must have two different languages");
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

        private void SetGUIToEditState()
        {
            btnRemoveWords.Enabled = true;
            lblWordTitle.Text = "Edit word";
        }

        private void SetGUIToCreateState()
        {
            btnRemoveWords.Enabled = false;
            lblWordTitle.Text = "Add word";
            ClearWordInputFields();
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

        private void SaveVocabularyData()
        {
            Vocabulary.Name = textBoxNameOfVocabulary.Text;
            Vocabulary.OriginalLanguage = comboBoxOriginalLanguage.SelectedItem.ToString();
            Vocabulary.TranslationLanguage = comboBoxTranslationLanguage.SelectedItem.ToString();
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

            UpdateWordsInGUI();

            listBoxWords.SelectedIndex = -1;
        }

        private void RemoveWordFromGUI(int index)
        {
            listBoxWords.Items.RemoveAt(index);
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






        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWords.SelectedIndex == -1)
            {
                SetGUIToCreateState();
                return;
            }

            if (listBoxWords.SelectedItems.Count == 1)
            {
                Word selectedWord = Vocabulary.GetWordAt(listBoxWords.SelectedIndex);
                FillWordInputFields(selectedWord);
                SetGUIToEditState();
            }
            else
            {
                ClearWordInputFields();
            }
            
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
                SetGUIToCreateState();
            }
        }

        private void btnRemoveWords_Click(object sender, EventArgs e)
        {
            if (listBoxWords.SelectedIndex == -1)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Sure you want to remove the marked words?",
                "Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            int nrOfWordsRemoved = 0;
            foreach (int index in listBoxWords.SelectedIndices)
            {
                int indexToRemoveAt = index - nrOfWordsRemoved;
                Vocabulary.RemoveWordAt(indexToRemoveAt);

                nrOfWordsRemoved++;
            }

            UpdateWordsInGUI();
            SetGUIToCreateState();
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
                SaveVocabularyData();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check if anything has been changed

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
