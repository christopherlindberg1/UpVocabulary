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
        private readonly VocabularyManager _vocabularyManager = new VocabularyManager();

        private FormCreateAndEdit _createAndEditForm;
        private FormPracticeSettings _practiceSettingsForm;
        private FormPractice _practiceForm;

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

        private VocabularyManager VocabularyManager
        {
            get => _vocabularyManager;

            //set
            //{
            //    VocabularyManager = value ??
            //        throw new ArgumentNullException(
            //            "VocabularyManager",
            //            "VocabularyManager cannot be null.");
            //}
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

        private void SetGUIToViewState()
        {
            btnStartPractice.Enabled = false;
            btnEditVocabulary.Enabled = false;
            btnRemoveVocabularies.Enabled = false;

            listViewVocabularies.SelectedItems.Clear();
        }

        private void SetGUIToEditState()
        {
            btnStartPractice.Enabled = true;
            btnEditVocabulary.Enabled = true;
            btnRemoveVocabularies.Enabled = true;
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

        private void LoadSampleData()
        {
            Word v1w1 = new Word
            (
                "also",
                "också",
                "",
                5,
                0
            );
            Word v1w2 = new Word
            (
                "paper",
                "papper",
                "",
                5,
                0
            );
            Word v1w3 = new Word
            (
                "zoo",
                "zoo",
                "",
                5,
                0
            );

            List<Word> v1words = new List<Word> { v1w1, v1w2, v1w3 };
            Vocabulary vocabulary1 = new Vocabulary("D is for Digital", v1words, "English", "Swedish");



            Word v2w1 = new Word
            (
                "also",
                "också",
                "Aaa aa aaaa",
                5,
                0
            );
            Word v2w2 = new Word
            (
                "paper",
                "papper",
                "Ccc!",
                5,
                0
            );
            Word v2w3 = new Word
            (
                "zoo",
                "zoo",
                "Eeee ee ee eee",
                5,
                0
            );

            List<Word> v2words = new List<Word> { v2w1, v2w2, v2w3 };
            Vocabulary vocabulary2 = new Vocabulary("Learn C#", v2words, "English", "Swedish");



            Word v3w1 = new Word
            (
                "also",
                "också",
                "Aaa aa aaaa",
                5,
                0
            );
            Word v3w2 = new Word
            (
                "paper",
                "papper",
                "Ccc!",
                5,
                0
            );
            Word v3w3 = new Word
            (
                "zoo",
                "zoo",
                "Eeee ee ee eee",
                5,
                0
            );

            List<Word> v3words = new List<Word> { v3w1, v3w2, v3w3 };
            Vocabulary vocabulary3 = new Vocabulary("Software engineering", v3words, "English", "Swedish");

            VocabularyManager.AddVocabulary(vocabulary1);
            VocabularyManager.AddVocabulary(vocabulary2);
            VocabularyManager.AddVocabulary(vocabulary3);
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
            CreateAndEditForm = new FormCreateAndEdit(
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
                VocabularyManager.GetNamesForAllVocabularies(),
                copyOfVocabulary);

            DialogResult result = CreateAndEditForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
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
    }
}
