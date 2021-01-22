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
        private AppSettings _appSettings;
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

        internal AppSettings AppSettings
        {
            get => _appSettings;

            set => _appSettings = value ??
                throw new ArgumentNullException(
                    "AppSettings",
                    "AppSettings Cannot be null");
        }

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

        public FormCreateAndEdit(AppSettings appSettings, string[] namesOfAllVocabularies)
        {
            InitializeComponent();

            AppSettings = appSettings;
            NamesOfAllVocabularies = namesOfAllVocabularies;
            EditingExistingVocabulary = false;

            InitializeForm();
        }

        public FormCreateAndEdit(AppSettings appSettings, string[] namesOfAllVocabularies, Vocabulary vocabulary)
        {
            InitializeComponent();

            AppSettings = appSettings;
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
            SetTextsAccordingToAppLanguage();
            FillLanguageMenusWithData();
            //SetLanguageLabelsForOriginalWordAndTranslation();
            SetGUIToCreateState();

            if (Vocabulary == null)
            {
                if (AppSettings.AppLanguage == AppLanguages.English)
                {
                    this.Text = FormCreateAndEditTexts.GetFormTitle_CreateMode_TextInEnglish();
                }
                else if (AppSettings.AppLanguage == AppLanguages.Swedish)
                {
                    this.Text = FormCreateAndEditTexts.GetFormTitle_CreateMode_TextInSwedish();
                }
            }
            else
            {
                if (AppSettings.AppLanguage == AppLanguages.English)
                {
                    this.Text = FormCreateAndEditTexts.GetFormTitle_EditMode_TextInEnglish();
                }
                else if (AppSettings.AppLanguage == AppLanguages.Swedish)
                {
                    this.Text = FormCreateAndEditTexts.GetFormTitle_EditMode_TextInSwedish();
                }

                InitializeGUIWithVocabularyData(Vocabulary);
            }
        }

        private void SetTextsAccordingToAppLanguage()
        {
            if (AppSettings == null)
            {
                throw new InvalidOperationException("cannot call this method is appsettings is null");
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
            // Settings the texts that vary depending on if user is creating
            // new vocabulary or editing an existing one
            if (EditingExistingVocabulary == false)
            {
                lblHeading.Text = FormCreateAndEditTexts.GetLblHeading_CreateMode_TextInEnglish();
            }
            else
            {
                lblHeading.Text = FormCreateAndEditTexts.GetLblHeading_EditMode_TextInEnglish();
            }

            // Setting texts that does not vary depending on why the user opened the form
            lblNameOfVocabulary.Text = FormCreateAndEditTexts.GetLblNameOfVocabulary_TextInEnglish();
            lblLanguages.Text = FormCreateAndEditTexts.GetLblLanguages_TextInEnglish();
            lblLanguageSwitch.Text = FormCreateAndEditTexts.GetLblLanguageSwitch_TextInEnglish();
            lblWordTitle.Text = FormCreateAndEditTexts.GetLblWordTitle_CreateMode_TextInEnglish();
            lblWordInOriginalLanguage.Text = FormCreateAndEditTexts.GetLblWordInOriginalLanguage_Default_TextInEnglish();
            lblTranslationOfWord.Text = FormCreateAndEditTexts.GetLblTranslationOfWord_Default_TextInEnglish();
            lblWordUsedInSentense.Text = FormCreateAndEditTexts.GetLblWordUsedInSentense_TextInEnglish();
            lblWordList.Text = FormCreateAndEditTexts.GetLblWordList_TextInEnglish();

            btnSaveWord.Text = FormCreateAndEditTexts.GetBtnSaveWord_TextInEnglish();
            btnCancelWordEditing.Text = FormCreateAndEditTexts.GetBtnCancelWordEditing_TextInEnglish();
            btnRemoveWords.Text = FormCreateAndEditTexts.GetBtnRemoveWords_TextInEnglish();
            btnSaveVocabulary.Text = FormCreateAndEditTexts.GetBtnSaveVocabulary_TextInEnglish();
            btnCancel.Text = FormCreateAndEditTexts.GetBtnCancel_TextInEnglish();
        }

        private void SetTextsToSwedish()
        {
            // Settings the texts that vary depending on if user is creating
            // new vocabulary or editing an existing one
            if (EditingExistingVocabulary == false)
            {
                lblHeading.Text = FormCreateAndEditTexts.GetLblHeading_CreateMode_TextInSwedish();
            }
            else
            {
                lblHeading.Text = FormCreateAndEditTexts.GetLblHeading_EditMode_TextInSwedish();
            }

            // Setting texts that does not vary depending on why the user opened the form
            lblNameOfVocabulary.Text = FormCreateAndEditTexts.GetLblNameOfVocabulary_TextInSwedish();
            lblLanguages.Text = FormCreateAndEditTexts.GetLblLanguages_TextInSwedish();
            lblLanguageSwitch.Text = FormCreateAndEditTexts.GetLblLanguageSwitch_TextInSwedish();
            lblWordTitle.Text = FormCreateAndEditTexts.GetLblWordTitle_CreateMode_TextInSwedish();
            lblWordInOriginalLanguage.Text = FormCreateAndEditTexts.GetLblWordInOriginalLanguage_Default_TextInSwedish();
            lblTranslationOfWord.Text = FormCreateAndEditTexts.GetLblTranslationOfWord_Default_TextInSwedish();
            lblWordUsedInSentense.Text = FormCreateAndEditTexts.GetLblWordUsedInSentense_TextInSwedish();
            lblWordList.Text = FormCreateAndEditTexts.GetLblWordList_TextInSwedish();

            btnSaveWord.Text = FormCreateAndEditTexts.GetBtnSaveWord_TextInSwedish();
            btnCancelWordEditing.Text = FormCreateAndEditTexts.GetBtnCancelWordEditing_TextInSwedish();
            btnRemoveWords.Text = FormCreateAndEditTexts.GetBtnRemoveWords_TextInSwedish();
            btnSaveVocabulary.Text = FormCreateAndEditTexts.GetBtnSaveVocabulary_TextInSwedish();
            btnCancel.Text = FormCreateAndEditTexts.GetBtnCancel_TextInSwedish();
        }

        private void FillLanguageMenusWithData()
        {
            string[] languages = Enum.GetNames(typeof(TranslationLanguages));

            comboBoxOriginalLanguage.Items.AddRange(languages);
            comboBoxTranslationLanguage.Items.AddRange(languages);
        }

        private void InitializeGUIWithVocabularyData(Vocabulary vocabulary)
        {
            textBoxNameOfVocabulary.Text = vocabulary.Name;
            AddWordsToGUIList(vocabulary);
            SetLanguagesInGUI(vocabulary);
        }

        





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

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

        private bool ValidateVocabularyData()
        {
            bool vocabularyNameOk = ValidateVocabularyName();
            bool vocabularyLanguagesOk = ValidateLanguages();

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
            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                lblWordTitle.Text = FormCreateAndEditTexts.GetLblWordTitle_EditMode_TextInEnglish();
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                lblWordTitle.Text = FormCreateAndEditTexts.GetLblWordTitle_EditMode_TextInSwedish();
            }

            btnRemoveWords.Enabled = true;
            btnCancelWordEditing.Enabled = true;
        }

        private void SetGUIToCreateState()
        {
            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                lblWordTitle.Text = FormCreateAndEditTexts.GetLblWordTitle_CreateMode_TextInEnglish();
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                lblWordTitle.Text = FormCreateAndEditTexts.GetLblWordTitle_CreateMode_TextInSwedish();
            }

            btnRemoveWords.Enabled = false;
            btnCancelWordEditing.Enabled = false;
            listBoxWords.SelectedIndex = -1;
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

        private void SetLanguageLabelsForOriginalWordAndTranslation()
        {
            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                if (comboBoxOriginalLanguage.SelectedIndex != -1)
                {
                    lblWordInOriginalLanguage.Text =
                        FormCreateAndEditTexts.GetLblWordInOriginalLanguage_SpecificToLanguage_TextInEnglish
                        (
                            comboBoxOriginalLanguage.SelectedItem.ToString()
                        );
                }

                if (comboBoxTranslationLanguage.SelectedIndex != -1)
                {
                    lblTranslationOfWord.Text = 
                        FormCreateAndEditTexts.GetLblTranslationOfWord_SpecificToLanguage_TextInEnglish
                        (
                            comboBoxTranslationLanguage.SelectedItem.ToString()
                        );
                }
            }
            else if (AppSettings.AppLanguage == AppLanguages.Swedish)
            {
                if (comboBoxOriginalLanguage.SelectedIndex != -1)
                {
                    lblWordInOriginalLanguage.Text =
                        FormCreateAndEditTexts.GetLblWordInOriginalLanguage_SpecificToLanguage_TextInSwedish
                        (
                            comboBoxOriginalLanguage.SelectedItem.ToString()
                        );
                }

                if (comboBoxTranslationLanguage.SelectedIndex != -1)
                {
                    lblTranslationOfWord.Text =
                        FormCreateAndEditTexts.GetLblTranslationOfWord_SpecificToLanguage_TextInSwedish
                        (
                            comboBoxTranslationLanguage.SelectedItem.ToString()
                        );
                }
            }
            
        }

        private void SaveVocabularyData()
        {
            Vocabulary.Name = textBoxNameOfVocabulary.Text;
            Vocabulary.OriginalLanguage = comboBoxOriginalLanguage.SelectedItem.ToString().ToLower();
            Vocabulary.TranslationLanguage = comboBoxTranslationLanguage.SelectedItem.ToString().ToLower();

            VocabularyHasBeenChanged = true;
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
            VocabularyHasBeenChanged = true;
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







        /**
         * 
         * ===================  Event Handlers  ===================
         * 
         */

        private void ListBoxWordsSelectedIndexChanged_EventHandler()
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

        private void SaveWord_EventHandler()
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

            textBoxWordInOriginalLanguage.Focus();
        }

        private void RemoveWords_EventHandler()
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

        private void SaveVocabulary_EventHandler()
        {
            bool vocabularyDataOk = ValidateVocabularyData();

            if (vocabularyDataOk == false)
            {
                MessageBox.Show(
                    InputValidator.GetMessages(),
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            SaveVocabularyData();
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void CancelVocabularyChanges_EventHandler()
        {
            if (VocabularyHasBeenChanged)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit without saving your changes?",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                this.Close();
            }
        }



        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxWordsSelectedIndexChanged_EventHandler();
        }

        private void comboBoxOriginalLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLanguageLabelsForOriginalWordAndTranslation();
        }

        private void comboBoxTranslationLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLanguageLabelsForOriginalWordAndTranslation();
        }

        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            SaveWord_EventHandler();
        }

        private void btnCancelWordEditing_Click(object sender, EventArgs e)
        {
            SetGUIToCreateState();
        }

        private void btnRemoveWords_Click(object sender, EventArgs e)
        {
            RemoveWords_EventHandler();
        }

        private void btnSaveVocabulary_Click(object sender, EventArgs e)
        {
            SaveVocabulary_EventHandler();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelVocabularyChanges_EventHandler();
        }
    }
}
