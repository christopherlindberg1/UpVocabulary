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
        private readonly InputValidator _inputValidator = new InputValidator();

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

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "CreateAndEditForm",
                        "CreateAndEditForm Cannot be null");
                }
                else
                {
                    _createAndEditForm = value;
                }
            }
        }

        private FormPracticeSettings PracticeSettingsForm
        {
            get => _practiceSettingsForm;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "PracticeSettingsForm",
                        "PracticeSettingsForm Cannot be null");
                }
                else
                {
                    _practiceSettingsForm = value;
                }
            }
        }

        private FormPractice PracticeForm
        {
            get => _practiceForm;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "PracticeForm",
                        "PracticeForm Cannot be null");
                }
                else
                {
                    _practiceForm = value;
                }
            }
        }

        private InputValidator InputValidator
        {
            get => _inputValidator;
        }

        private string[] LanguagesToPracticeWith
        {
            get => _languagesToPracticeWith;

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "LanguagesToPracticeWith",
                        "LanguagesToPracticeWith Cannot be null");
                }
                else
                {
                    _languagesToPracticeWith = value;
                }
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





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormMain()
        {
            InitializeComponent();

            ConfigureListViewVocabularies();
        }

        private void InitializeApp()
        {
            FillStoreWithSampleData();
            AddDataToGUI();
        }

        private void TestingMethod()
        {
            

            this.Close();
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

            // Fill the app with sample data
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void FillStoreWithSampleData()
        {
            Word w1 = new Word
            {
                OriginalWord = "also",
                Translation = "också",
                Sentence = "I am also happy",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w2 = new Word
            {
                OriginalWord = "happy",
                Translation = "glad",
                Sentence = "I am happy",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w3 = new Word
            {
                OriginalWord = "hello",
                Translation = "hej",
                Sentence = "Hello there my little cat",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w4 = new Word
            {
                OriginalWord = "yes",
                Translation = "yes",
                Sentence = "yes, my name is Chris",
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };
            Word w5 = new Word
            {
                OriginalWord = "zoo",
                Translation = "zoo",
                Sentence = null,
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };

            List<Word> words1 = new List<Word> { w1, w2, w3, w4, w5 };
            Vocabulary vocabulary = new Vocabulary("D is for Digital", words1, "English", "Swedish");

            Word w6 = new Word
            {
                OriginalWord = "ö",
                Translation = "ö",
                Sentence = null,
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };

            Word w7 = new Word
            {
                OriginalWord = "ööö",
                Translation = "ocksååå",
                Sentence = null,
                Weight = 5,
                TimesAnsweredCorrectly = 0
            };

            //vocabulary.InsertWord(word1);

            //bool didUpdate = vocabulary.UpdateWord("ö", word2);

            VocabularyManager.AddVocabulary(vocabulary);

            MessageBox.Show((VocabularyManager.GetAtIndex(0)).ToString());
        }

        private void AddDataToGUI()
        {
            listViewVocabularies.Items.Clear();

            Vocabulary vocabulary;

            for (int i = 0; i < VocabularyManager.NrOfVocabularies; i++)
            {
                vocabulary = VocabularyManager.GetAtIndex(0);

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeApp();
        }
    }
}
