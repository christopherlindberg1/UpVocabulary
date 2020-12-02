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
            Word v1w1 = new Word
            (
                "also",
                "också",
                "Aaa aa aaaa",
                5,
                0
            );
            Word v1w2 = new Word
            (
                "paper",
                "papper",
                "Ccc!",
                5,
                0
            );
            Word v1w3 = new Word
            (
                "zoo",
                "zoo",
                "Eeee ee ee eee",
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
            AddVocabularysDataToGUI();   
        }

        private void AddVocabularysDataToGUI()
        {
            listViewVocabularies.Items.Clear();

            Vocabulary vocabulary;

            for (int i = 0; i < VocabularyManager.NrOfVocabularies; i++)
            {
                vocabulary = VocabularyManager.GetVocabularyAt(i);

                ListViewItem item = new ListViewItem(vocabulary.Name);

                item.SubItems.Add(vocabulary.NrOfWords.ToString());
                item.SubItems.Add($"{ vocabulary.OriginalLanguage } - { vocabulary.TranslationLanguage }");

                listViewVocabularies.Items.Add(item);
            }
        }

        private void DeleteVocabulary()
        {

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

            ListViewItem item = listViewVocabularies.SelectedItems[0];

            Vocabulary vocabularyToEdit = VocabularyManager.GetVocabulary(item.Text);

            CreateAndEditForm = new FormCreateAndEdit(vocabularyToEdit);

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

        private void btnDeleteVocabulary_Click(object sender, EventArgs e)
        {

        }
    }
}
