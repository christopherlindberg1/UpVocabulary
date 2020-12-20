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
    public partial class Form1 : Form
    {
        private Button _currentButton;
        private Form _activeForm;







        /**
         * 
         * ===================  Properties  ===================
         * 
         */

        // Colors
        public Color ColorDefault { get; } = Color.FromArgb(51, 51, 76);
        public Color ColorBtnActive { get; } = Color.Blue;


        private Button CurrentButton
        {
            get => _currentButton;

            set => _currentButton = value ??
                throw new ArgumentNullException(
                    "CurrentButton",
                    "CurrentButton cannot be null.");
        }

        private Form ActiveForm
        {
            get => _activeForm;

            set => _activeForm = value ??
                throw new ArgumentNullException(
                    "ActiveForm",
                    "ActiveForm cannot be null.");
        }





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public Form1()
        {
            InitializeComponent();

            ActiveForm = new FormMain();

        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void ActivateButton(Button btnSender)
        {
            if (btnSender == null)
            {
                return;
            }
            

            if (btnSender != CurrentButton)
            {
                DeactivateButtons();

                CurrentButton = btnSender;
                CurrentButton.BackColor = ColorBtnActive;
            }
        }

        private void DeactivateButtons()
        {
            foreach (Control element in panelMenu.Controls)
            {
                if (element.GetType() == typeof(Button))
                {
                    element.BackColor = ColorDefault;
                }
            }
        }

        private void OpenChildForm(Form childForm, Button btnSender)
        {
            if (childForm != null)
            {
                ActiveForm.Close();
            }

            ActivateButton(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(childForm);
            panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }







        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void btnVocabularies_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMain(), (Button)sender);
        }

        private void btnAddVocabulary_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender);
        }
    }
}
