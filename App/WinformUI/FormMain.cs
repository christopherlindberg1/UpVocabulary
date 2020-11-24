using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private FormCreateAndEdit _createAndEditForm;
        private FormPracticeSettings _practiceSettingsForm;
        private FormPractice _practiceForm;
        private InputValidator _inputValidator;

        private int _nrOfWordsToPracticeWith;
        private string[] _languagesToPracticeWith;






        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        private FormCreateAndEdit CreateAndEditForm
        {
            get
            {
                return _createAndEditForm;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("CreateAndEditForm", "Cannot be null");
                }
                else
                {
                    _createAndEditForm = value;
                }
            }
        }

        private FormPracticeSettings PracticeSettingsForm
        {
            get
            {
                return _practiceSettingsForm;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("PracticeSettingsForm", "Cannot be null");
                }
                else
                {
                    _practiceSettingsForm = value;
                }
            }
        }

        private FormPractice PracticeForm
        {
            get
            {
                return _practiceForm;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("PracticeForm", "Cannot be null");
                }
                else
                {
                    _practiceForm = value;
                }
            }
        }

        private InputValidator InputValidator
        {
            get
            {
                return _inputValidator;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("InputValidator", "Cannot be null");
                }
                else
                {
                    _inputValidator = value;
                }
            }
        }

        private string[] LanguagesToPracticeWith
        {
            get
            {
                return _languagesToPracticeWith;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("LanguagesToPracticeWith", "Cannot be null");
                }
                else
                {
                    _languagesToPracticeWith = value;
                }
            }
        }

        private int NrOfWordsToPracticeWith
        {
            get
            {
                return _nrOfWordsToPracticeWith;
            }
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

        





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormMain()
        {
            InitializeComponent();

            InitializeListViewVocabularies();
        }

        private void InitializeListViewVocabularies()
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

            // Filling the app with sample data
            //AnimalManager.FillManagerWithSampleData();
            //AddAnimalsToGUIList();
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */





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
                // Hämta practice settings från formuläret
                //NrOfWordsToPracticeWith = ;
            }
        }
    }
}
