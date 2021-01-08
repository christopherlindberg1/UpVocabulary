using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DataAccess;
using AppFeatures;

namespace WinformUI
{
    public partial class FormMain : Form
    {
        private AppSettings _appSettings;

        private FormCreateAndEdit _createAndEditForm;
        private FormPracticeSettings _practiceSettingsForm;
        private FormPractice _practiceForm;
        private FormAppSettings _appSettingsForm;

        private readonly VocabularyManager _vocabularyManager = new VocabularyManager();
        private string _originalLanguageToPracticeWith;
        private string _translationLanguageToPracticeWith;
        private int _nrOfWordsToPracticeWith;
        private bool _promptWithOriginalLanguageInPractice;
        private bool _useLimitedAmountOfWordsInPractice;





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
                    "AppSettings Cannot be null");
        }
        

        private FormCreateAndEdit CreateAndEditForm
        {
            get => _createAndEditForm;

            set => _createAndEditForm = value ??
                throw new ArgumentNullException(
                    "CreateAndEditForm",
                    "CreateAndEditForm Cannot be null");
        }

        private FormPracticeSettings PracticeSettingsForm
        {
            get => _practiceSettingsForm;

            set => _practiceSettingsForm = value ??
                throw new ArgumentNullException(
                    "PracticeSettingsForm",
                    "PracticeSettingsForm Cannot be null");
        }

        private FormPractice PracticeForm
        {
            get => _practiceForm;

            set => _practiceForm = value ??
                throw new ArgumentNullException(
                    "PracticeForm",
                    "PracticeForm Cannot be null");
        }

        private FormAppSettings AppSettingsForm
        {
            get => _appSettingsForm;

            set => _appSettingsForm = value ??
                throw new ArgumentNullException(
                    "FormAppSettings",
                    "FormAppSettings Cannot be null");
        }

        private VocabularyManager VocabularyManager
        {
            get => _vocabularyManager;
        }

        public string OriginalLanguageToPracticeWith
        {
            get => _originalLanguageToPracticeWith;

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        "OriginalLanguage",
                        "OriginalLanguage cannot be null");
                }

                _originalLanguageToPracticeWith = value;
            }
        }

        public string TranslationLanguageToPracticeWith
        {
            get => _translationLanguageToPracticeWith;

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        "TranslationLanguage",
                        "TranslationLanguage cannot be null");
                }

                _translationLanguageToPracticeWith = value;
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
                        "NrOfWordsToPracticeWith Must be at least zero");
                }
                else
                {
                    _nrOfWordsToPracticeWith = value;
                }
            }
        }

        public bool PromptWithOriginalLanguageInPractice
        {
            get => _promptWithOriginalLanguageInPractice;

            set => _promptWithOriginalLanguageInPractice = value;
        }

        public bool UseLimitedAmountOfWordsInPractice
        {
            get => _useLimitedAmountOfWordsInPractice;

            set => _useLimitedAmountOfWordsInPractice = value;
        }





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormMain()
        {
            InitializeComponent();

            GetAppSettingsFromStorage();

            InitializeApp();
        }
        private void InitializeApp()
        {
            ConfigureGUIOnInit();
            LoadDataOnInit();
            AddDataToGUI();
        }

        private void ConfigureGUIOnInit()
        {
            ConfigureListViewVocabularies();
            SetTextsAccordingToAppLanguage();
            SetGUIToViewState();
        }

        private void UpdateGUIToMatchAppSettings()
        {
            SetTextsAccordingToAppLanguage();
            SetGUIToViewState();
        }

        private void ConfigureListViewVocabularies()
        {
            // Setting width for columns
            listViewVocabularies.Columns[0].Width = 225;     // Name
            listViewVocabularies.Columns[1].Width = 95;      // Nr of words
            listViewVocabularies.Columns[2].Width = 165;     // Languages
            listViewVocabularies.Columns[3].Width = 120;     // Languages

            listViewVocabularies.Width =
                listViewVocabularies.Columns[0].Width +
                listViewVocabularies.Columns[1].Width +
                listViewVocabularies.Columns[2].Width +
                listViewVocabularies.Columns[3].Width +
                4;

            // Set the view to show details.
            listViewVocabularies.View = View.Details;
            // Allow the user to rearrange columns.
            listViewVocabularies.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            listViewVocabularies.FullRowSelect = true;
            // Display grid lines.
            listViewVocabularies.GridLines = true;
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
            lblHeading.Text = FormMainTexts.GetLblHeading_TextInEnglish();

            btnCreateNewVocabulary.Text = FormMainTexts.GetBtnCreateNewVocabulary_TextInEnglish();
            btnStartPractice.Text = FormMainTexts.GetBtnStartPractice_TextInEnglish();
            btnEditVocabulary.Text = FormMainTexts.GetBtnEditVocabulary_TextInEnglish();
            btnRemoveVocabularies.Text = FormMainTexts.GetBtnRemoveVocabularies_TextInEnglish();

            listViewVocabularies_Name.Text = FormMainTexts.GetListViewVocabularies_Name_TextInEnglish();
            listViewVocabularies_NrOfWords.Text = FormMainTexts.GetListViewVocabularies_NrOfWords_TextInEnglish();
            listViewVocabularies_Languages.Text = FormMainTexts.GetListViewVocabularies_Languages_TextInEnglish();
            listViewVocabularies_DateLastUsed.Text = FormMainTexts.GetListViewVocabularies_DateLastUsed_TextInEnglish();
        }

        private void SetTextsToSwedish()
        {
            lblHeading.Text = FormMainTexts.GetLblHeading_TextInSwedish();

            btnCreateNewVocabulary.Text = FormMainTexts.GetBtnCreateNewVocabulary_TextInSwedish();
            btnStartPractice.Text = FormMainTexts.GetBtnStartPractice_TextInSwedish();
            btnEditVocabulary.Text = FormMainTexts.GetBtnEditVocabulary_TextInSwedish();
            btnRemoveVocabularies.Text = FormMainTexts.GetBtnRemoveVocabularies_TextInSwedish();

            listViewVocabularies_Name.Text = FormMainTexts.GetListViewVocabularies_Name_TextInSwedish();
            listViewVocabularies_NrOfWords.Text = FormMainTexts.GetListViewVocabularies_NrOfWords_TextInSwedish();
            listViewVocabularies_Languages.Text = FormMainTexts.GetListViewVocabularies_Languages_TextInSwedish();
            listViewVocabularies_DateLastUsed.Text = FormMainTexts.GetListViewVocabularies_DateLastUsed_TextInSwedish();
        }

        private void SetGUIToViewState()
        {
            btnStartPractice.Enabled = false;
            btnStartPractice.BackColor = Color.FromArgb(190, 190, 190);
            btnEditVocabulary.Enabled = false;
            btnEditVocabulary.BackColor = Color.FromArgb(190, 190, 190);
            btnRemoveVocabularies.Enabled = false;
            btnRemoveVocabularies.BackColor = Color.FromArgb(190, 190, 190);

            listViewVocabularies.SelectedItems.Clear();
        }

        private void SetGUIToEditState()
        {
            btnStartPractice.Enabled = true;
            btnStartPractice.BackColor = Color.DodgerBlue;
            btnEditVocabulary.Enabled = true;
            btnEditVocabulary.BackColor = Color.DodgerBlue;
            btnRemoveVocabularies.Enabled = true;
            btnRemoveVocabularies.BackColor = Color.DodgerBlue;
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void LoadDataOnInit()
        {
            LoadVocabularyManagerFromStorage();
        }

        private void GetAppSettingsFromStorage()
        {
            try
            {
                AppSettings = Serializer.XmlDeserialize<AppSettings>(FilePaths.AppSettingsFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SaveAppSettingsToStorage()
        {
            Serializer.XmlSerialize<AppSettings>(FilePaths.AppSettingsFilePath, AppSettings);
        }

        private void LoadVocabularyManagerFromStorage()
        {
            try
            {
                PopulateVocabularyManagerWithData(Serializer.XmlDeserialize<VocabularyManager>(FilePaths.VocabularyManagerFilePath));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void PopulateVocabularyManagerWithData(VocabularyManager vocabularyManagerToCopy)
        {
            for (int i = 0; i < vocabularyManagerToCopy.NrOfVocabularies; i++)
            {
                VocabularyManager.AddVocabulary(vocabularyManagerToCopy.GetVocabularyAt(i));
            }
        }

        private void SaveVocabularyManagerToStorage()
        {
            try
            {
                Serializer.XmlSerialize<VocabularyManager>(FilePaths.VocabularyManagerFilePath, VocabularyManager);
            }
            // Catch more specific exceptions
            catch (Exception ex)
            {
                throw;
            }
        }

        private void AddDataToGUI()
        {
            UpdateVocabulariesInGUI();   
        }

        private void UpdateVocabulariesInGUI()
        {
            listViewVocabularies.Items.Clear();

            Vocabulary vocabulary;

            for (int i = 0; i < VocabularyManager.NrOfVocabularies; i++)
            {
                vocabulary = VocabularyManager.GetVocabularyAt(i);

                ListViewItem item = new ListViewItem(vocabulary.Name);

                item.SubItems.Add(vocabulary.NrOfWords.ToString());
                item.SubItems.Add($"{ vocabulary.OriginalLanguage } - { vocabulary.TranslationLanguage }");
                item.SubItems.Add(vocabulary.DateLastUsed.ToShortDateString());

                listViewVocabularies.Items.Add(item);
            }
        }

        private void RemoveVocabularyFromGUI(int index)
        {
            listViewVocabularies.Items.RemoveAt(index);
        }

        private void GetPracticeSettings()
        {
            NrOfWordsToPracticeWith = PracticeSettingsForm.NrOfWordsToPracticeWith;
            PromptWithOriginalLanguageInPractice = PracticeSettingsForm.PromptWithOriginalLanguage;
            UseLimitedAmountOfWordsInPractice = PracticeSettingsForm.UseLimitedAmountOfWords;
        }

        private void ListViewVocabulariesIndexChanged_EventHandler()
        {
            if (listViewVocabularies.SelectedIndices.Count == 0)
            {
                SetGUIToViewState();
            }
            else
            {
                SetGUIToEditState();
            }
        }

        private void CreateVocabulary_EventHandler()
        {
            CreateAndEditForm = new FormCreateAndEdit(AppSettings,
                VocabularyManager.GetNamesForAllVocabularies());

            DialogResult result = CreateAndEditForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                VocabularyManager.AddVocabulary(CreateAndEditForm.Vocabulary);
                SaveVocabularyManagerToStorage();
                UpdateVocabulariesInGUI();
            }

            SetGUIToViewState();
        }

        private void EditVocabulary_EventHandler()
        {
            if (listViewVocabularies.SelectedItems.Count == 0)
            {
                return;
            }

            if (listViewVocabularies.SelectedItems.Count > 1)
            {
                MessageBox.Show(
                    "Select only one vocabulary if you want to edit it.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int selectedIndex = listViewVocabularies.SelectedIndices[0];

            Vocabulary copyOfVocabulary = VocabularyManager.GetCopyOfVocabulary(selectedIndex);

            CreateAndEditForm = new FormCreateAndEdit(
                AppSettings,
                VocabularyManager.GetNamesForAllVocabularies(),
                copyOfVocabulary);

            DialogResult result = CreateAndEditForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes");

                Vocabulary originalVocabulary = VocabularyManager.GetVocabularyAt(selectedIndex);

                VocabularyManager.UpdateVocabulary(originalVocabulary, copyOfVocabulary);
                SaveVocabularyManagerToStorage();
                UpdateVocabulariesInGUI();
            }

            SetGUIToViewState();
        }

        private void RemoveVocabularies_EventHandler()
        {
            if (listViewVocabularies.SelectedItems.Count == 0)
            {
                return;
            }

            StringBuilder message = new StringBuilder();
            message.Append("Are you sure you want to remove the following vocabularies?\n\n");

            for (int i = 0; i < listViewVocabularies.SelectedItems.Count; i++)
            {
                message.Append(
                    $"* { listViewVocabularies.SelectedItems[i].Text }\n");
            }

            DialogResult result = MessageBox.Show(
                message.ToString(),
                "Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else if (result == DialogResult.OK)
            {
                int itemsRemoved = 0;
                foreach (int index in listViewVocabularies.SelectedIndices)
                {
                    RemoveVocabularyFromGUI(index - itemsRemoved);
                    VocabularyManager.RemoveAt(index - itemsRemoved);

                    itemsRemoved++;
                }

                SaveVocabularyManagerToStorage();
            }
            else
            {
                throw new InvalidOperationException("Dialog result is invalid.");
            }

            SetGUIToViewState();
        }

        private void StartPractice_EventHandler()
        {
            if (listViewVocabularies.SelectedItems.Count == 0)
            {
                return;
            }

            if (listViewVocabularies.SelectedItems.Count > 1)
            {
                MessageBox.Show(
                    "Select only one vocabulary to practice with",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            Vocabulary vocabularyToPracticeWith =
                VocabularyManager.GetVocabularyAt(listViewVocabularies.SelectedIndices[0]);

            if (vocabularyToPracticeWith.NrOfWords == 0)
            {
                MessageBox.Show(
                    $"{ vocabularyToPracticeWith.Name } does not have any words. " +
                    "Add words to it first.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            PracticeSettingsForm = new FormPracticeSettings(vocabularyToPracticeWith);

            DialogResult result = PracticeSettingsForm.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            GetPracticeSettings();
            PracticeForm = new FormPractice(
                AppSettings,
                vocabularyToPracticeWith,
                NrOfWordsToPracticeWith,
                PromptWithOriginalLanguageInPractice,
                UseLimitedAmountOfWordsInPractice);

            PracticeForm.ShowDialog();
            vocabularyToPracticeWith.UpdateDateLastUsed();

            SaveVocabularyManagerToStorage();
            UpdateVocabulariesInGUI();
            SetGUIToViewState();
        }

        private void OpenAppSettingsForm_EventHandler()
        {
            AppSettingsForm = new FormAppSettings(new AppSettings(AppSettings));
            DialogResult result = AppSettingsForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                AppSettings = new AppSettings(AppSettingsForm.AppSettings);
                SaveAppSettingsToStorage();
                UpdateGUIToMatchAppSettings();
            }
        }






        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeApp();
        }

        private void listViewVocabularies_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewVocabulariesIndexChanged_EventHandler();
        }

        private void btnCreateNewVocabulary_Click(object sender, EventArgs e)
        {
            CreateVocabulary_EventHandler();
        }

        private void btnEditVocabulary_Click(object sender, EventArgs e)
        {
            EditVocabulary_EventHandler();
        }

        private void btnRemoveVocabularies_Click(object sender, EventArgs e)
        {
            RemoveVocabularies_EventHandler();
        }

        private void btnStartPractice_Click(object sender, EventArgs e)
        {
            StartPractice_EventHandler();
        }

        private void listViewVocabularies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StartPractice_EventHandler();
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            OpenAppSettingsForm_EventHandler();
        }
    }
}
