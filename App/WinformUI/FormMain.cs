using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private int _nrOfWordsToPracticeWith;
        private string[] _languagesToPracticeWith;





        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private VocabularyManager VocabularyManager
        {
            get => _vocabularyManager;
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

        private string[] LanguagesToPracticeWith
        {
            get => _languagesToPracticeWith;

            set => _languagesToPracticeWith = value ??
                throw new ArgumentNullException(
                    "LanguagesToPracticeWith",
                    "LanguagesToPracticeWith Cannot be null");
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
            LoadSampleData();
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
            listViewVocabularies.Columns[1].Width = 100;     // Nr of words
            listViewVocabularies.Columns[2].Width = 150;     // Languages

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
            btnDeleteVocabulary.Enabled = false;
        }

        private void SetGUIToEditState()
        {
            btnStartPractice.Enabled = true;
            btnEditVocabulary.Enabled = true;
            btnDeleteVocabulary.Enabled = true;
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void LoadSampleData()
        {
            Word w1 = new Word
            (
                "aaaa",
                "aaaa",
                "Aaa aa aaaa",
                5,
                0
            );
            Word w2 = new Word
            (
                "c",
                "c",
                "Ccc!",
                5,
                0
            );
            Word w3 = new Word
            (
                "e",
                "eeeeeee",
                "Eeee ee ee eee",
                5,
                0
            );

            List<Word> words1 = new List<Word> { w1, w2, w3 };
            Vocabulary vocabulary = new Vocabulary("D is for Digital", words1, "English", "Swedish");

            VocabularyManager.AddVocabulary(vocabulary);
        }

        private void AddDataToGUI()
        {
            AddVocabularysDataToGUI();   
        }

        private void AddVocabularysDataToGUI()
        {
            listViewVocabularies.Items.Clear();

            Vocabulary vocabulary;

            for (int i = 0; i < VocabularyManager.NrOfVocabularies; i++)
            {
                vocabulary = VocabularyManager.GetVocabularyAt(0);

                ListViewItem item = new ListViewItem(vocabulary.Name);

                item.SubItems.Add(vocabulary.NrOfWords.ToString());
                item.SubItems.Add($"{ vocabulary.OriginalLanguage } - { vocabulary.TranslationLanguage }");

                listViewVocabularies.Items.Add(item);
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

        private void btnCreateNewVocabulary_Click(object sender, EventArgs e)
        {
            CreateAndEditForm = new FormCreateAndEdit();

            CreateAndEditForm.Show();
        }

        private void btnEditVocabulary_Click(object sender, EventArgs e)
        {
            CreateAndEditForm = new FormCreateAndEdit(new VocabularyModel());

            CreateAndEditForm.Show();
        }

        private void btnStartPractice_Click(object sender, EventArgs e)
        {
            FormPracticeSettings practiceSettings = new FormPracticeSettings();

            DialogResult result = practiceSettings.ShowDialog();

            if (result == DialogResult.Yes)
            {
                // Get practice settings from the form.
                
            }
        }

        private void listViewVocabularies_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
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
    }
}
