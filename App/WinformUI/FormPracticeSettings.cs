using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class FormPracticeSettings : Form
    {
        private DialogResult _startPractice;
        private string[] _languagesToPracticeWith = new string[] { "Swedish", "English" };
        private int _nrOfWordsToPracticeWith = 0;




        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        public DialogResult StartPractice
        {
            get => _startPractice;

            set
            {
                if (value != DialogResult.Yes && value != DialogResult.Cancel)
                {
                    throw new ArgumentException("Dialog result must be 'Yes' or 'Cancel'", "StartPractice");
                }
                else
                {
                    _startPractice = value;
                }
            }
        }

        private string[] LanguagesToPracticeWith
        {
            get => _languagesToPracticeWith;

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
            get => _nrOfWordsToPracticeWith;

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
         * ===================  Events  ===================
         * 
         */

        public FormPracticeSettings()
        {
            InitializeComponent();
        }




        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void SavePracticeSettings()
        {

        }





        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void btnStartPractice_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            
            // Save practice settings


            this.Close();
        }

        private void FormPracticeSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
