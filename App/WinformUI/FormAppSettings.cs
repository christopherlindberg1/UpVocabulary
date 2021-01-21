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
    public partial class FormAppSettings : Form
    {
        private AppSettings _appSettings;
        private readonly InputValidator _inputValidator = new InputValidator();





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





        /**
         * 
         * ===================  Init  ===================
         * 
         */

        public FormAppSettings(AppSettings appSettings)
        {
            InitializeComponent();

            AppSettings = appSettings;

            InitializeForm();
        }

        public void InitializeForm()
        {
            InitializeGUI();
        }

        public void InitializeGUI()
        {
            SetTextsAccordingToAppLanguage();
            InitializeAppSettingsInGUI();
        }

        private void SetTextsAccordingToAppLanguage()
        {
            if (AppSettings == null)
            {
                throw new InvalidOperationException("Cannot call this method if AppSettings is null");
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
            // Form heading
            this.Text = FormAppSettingsTexts.GetFormTitle_TextInEnglish();

            // Heading elements
            lblSettingsHeading.Text = FormAppSettingsTexts.GetLblSettingsHeading_TextInEnglish();

            // Language elements
            lblLanguage.Text = FormAppSettingsTexts.GetLblLanguage_TextInEnglish();
            btnLanguageEnglish.Text = FormAppSettingsTexts.GetBtnLanguageEnglish_TextInEnglish();
            btnLanguageSwedish.Text = FormAppSettingsTexts.GetBtnLanguageSwedish_TextInEnglish();

            // Auto prompt elements
            lblAutoPrompt.Text = FormAppSettingsTexts.GetLblAutoPrompt_TextInEnglish();
            
            lblAutoPromptCorrect.Text = FormAppSettingsTexts.GetLblAutoPromptCorrect_TextInEnglish();
            btnAutoPromptCorrectYes.Text = FormAppSettingsTexts.GetBtnAutoPromptCorrectYes_TextInEnglish();
            btnAutoPromptCorrectNo.Text = FormAppSettingsTexts.GetBtnAutoPromptCorrectNo_TextInEnglish();

            lblAutoPromptIncorrect.Text = FormAppSettingsTexts.GetLblAutoPromptIncorrect_TextInEnglish();
            btnAutoPromptIncorrectYes.Text = FormAppSettingsTexts.GetBtnAutoPromptIncorrectYes_TextInEnglish();
            btnAutoPromptIncorrectNo.Text = FormAppSettingsTexts.GetBtnAutoPromptIncorrectNo_TextInEnglish();

            // Delay prompt elements
            lblDelayBeforePrompt.Text = FormAppSettingsTexts.GetLblDelayBeforePrompt_TextInEnglish();
            lblDelayBeforePromptCorrect.Text = FormAppSettingsTexts.GetLblDelayBeforePromptCorrect_TextInEnglish();
            lblDelayBeforePromptIncorrect.Text = FormAppSettingsTexts.GetLblDelayBeforePromptIncorrect_TextInEnglish();

            // Buttons
            btnSaveSettings.Text = FormAppSettingsTexts.GetBtnSaveSettings_TextInEnglish();
        }

        private void SetTextsToSwedish()
        {
            // Form heading
            this.Text = FormAppSettingsTexts.GetFormTitle_TextInSwedish();

            // Heading elements
            lblSettingsHeading.Text = FormAppSettingsTexts.GetLblSettingsHeading_TextInSwedish();

            // Language elements
            lblLanguage.Text = FormAppSettingsTexts.GetLblLanguage_TextInSwedish();
            btnLanguageEnglish.Text = FormAppSettingsTexts.GetBtnLanguageEnglish_TextInSwedish();
            btnLanguageSwedish.Text = FormAppSettingsTexts.GetBtnLanguageSwedish_TextInSwedish();

            // Auto prompt elements
            lblAutoPrompt.Text = FormAppSettingsTexts.GetLblAutoPrompt_TextInSwedish();

            lblAutoPromptCorrect.Text = FormAppSettingsTexts.GetLblAutoPromptCorrect_TextInSwedish();
            btnAutoPromptCorrectYes.Text = FormAppSettingsTexts.GetBtnAutoPromptCorrectYes_TextInSwedish();
            btnAutoPromptCorrectNo.Text = FormAppSettingsTexts.GetBtnAutoPromptCorrectNo_TextInSwedish();

            lblAutoPromptIncorrect.Text = FormAppSettingsTexts.GetLblAutoPromptIncorrect_TextInSwedish();
            btnAutoPromptIncorrectYes.Text = FormAppSettingsTexts.GetBtnAutoPromptIncorrectYes_TextInSwedish();
            btnAutoPromptIncorrectNo.Text = FormAppSettingsTexts.GetBtnAutoPromptIncorrectNo_TextInSwedish();

            // Delay prompt elements
            lblDelayBeforePrompt.Text = FormAppSettingsTexts.GetLblDelayBeforePrompt_TextInSwedish();
            lblDelayBeforePromptCorrect.Text = FormAppSettingsTexts.GetLblDelayBeforePromptCorrect_TextInSwedish();
            lblDelayBeforePromptIncorrect.Text = FormAppSettingsTexts.GetLblDelayBeforePromptIncorrect_TextInSwedish();

            // Buttons
            btnSaveSettings.Text = FormAppSettingsTexts.GetBtnSaveSettings_TextInSwedish();
        }

        private void InitializeAppSettingsInGUI()
        {
            SetLanguageSettingInGUI();
            SetAutoPromptSettingsInGUI();
            SetPromptDelaySettingsInGUI();
        }

        /// <summary>
        ///   Updates the buttons.
        /// </summary>
        private void UpdateGUIAccordingToAppSettings()
        {
            SetTextsAccordingToAppLanguage();
            SetLanguageSettingInGUI();
            SetAutoPromptSettingsInGUI();
        }

        private void SetLanguageSettingInGUI()
        {
            if (AppSettings.AppLanguage == AppLanguages.English)
            {
                MakeButtonSelected(btnLanguageEnglish);
                MakeButtonUnselected(btnLanguageSwedish);
            }
            else
            {
                MakeButtonSelected(btnLanguageSwedish);
                MakeButtonUnselected(btnLanguageEnglish);
            }
        }

        private void SetAutoPromptSettingsInGUI()
        {
            // Buttons for when user has given a correct translation
            if (AppSettings.AutoPromptQuestionAfterCorrectAnswer)
            {
                MakeButtonSelected(btnAutoPromptCorrectYes);
                MakeButtonUnselected(btnAutoPromptCorrectNo);
            }
            else
            {
                MakeButtonSelected(btnAutoPromptCorrectNo);
                MakeButtonUnselected(btnAutoPromptCorrectYes);
            }

            // Buttons for when user has given an incorrect translation
            if (AppSettings.AutoPromptQuestionAfterIncorrectAnswer)
            {
                MakeButtonSelected(btnAutoPromptIncorrectYes);
                MakeButtonUnselected(btnAutoPromptIncorrectNo);
            }
            else
            {
                MakeButtonSelected(btnAutoPromptIncorrectNo);
                MakeButtonUnselected(btnAutoPromptIncorrectYes);
            }
        }

        private void SetPromptDelaySettingsInGUI()
        {
            // Set the values for both properties
            textBoxDelayBeforePromptCorrect.Text =
                AppSettings.DelayBeforePromptingNextQuestionAfterCorrectAnswer.ToString();

            textBoxDelayBeforePromptIncorrect.Text =
                AppSettings.DelayBeforePromptingNextQuestionAfterIncorrectAnswer.ToString();

            // Enable / disable fields depending on if auto prompt is activated
            if (AppSettings.AutoPromptQuestionAfterCorrectAnswer)
            {
                textBoxDelayBeforePromptCorrect.Enabled = true;
            }
            else
            {
                textBoxDelayBeforePromptCorrect.Enabled = false;
            }

            if (AppSettings.AutoPromptQuestionAfterIncorrectAnswer)
            {
                textBoxDelayBeforePromptIncorrect.Enabled = true;
            }
            else
            {
                textBoxDelayBeforePromptIncorrect.Enabled = false;
            }
        }





        /**
         * 
         * ===================  Methods  ===================
         * 
         */

        private void MakeButtonSelected(Button button)
        {
            button.BackColor = Color.DodgerBlue;
            button.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            button.ForeColor = Color.White;
        }

        private void MakeButtonUnselected(Button button)
        {
            button.BackColor = Color.FromArgb(230, 230, 230);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 190, 190);
            button.ForeColor = Color.Black;
        }

        private void ToggleDelayBeforePromptCorrect(bool enabled)
        {
            textBoxDelayBeforePromptCorrect.Enabled = enabled;
        }

        private void ToggleDelayBeforePromptIncorrect(bool enabled)
        {
            textBoxDelayBeforePromptIncorrect.Enabled = enabled;
        }

        private bool ValidateInput()
        {
            bool correctDelayOk = ValidateDelayAfterCorrectAnswer();
            bool incorrectDelayOk = ValidateDelayAfterIncorrectAnswer();

            return correctDelayOk && incorrectDelayOk;
        }

        private bool ValidateDelayAfterCorrectAnswer()
        {
            return ValidateDelay(
                textBoxDelayBeforePromptCorrect,
                "Delay after correct answer cannot be empty.",
                "Delay after correct answer must be a whole number.",
                "Delay after correct answer must be in the range 0 - 30000 milliseconds.");
        }

        private bool ValidateDelayAfterIncorrectAnswer()
        {
            return ValidateDelay(
                textBoxDelayBeforePromptIncorrect,
                "Delay after incorrect answer cannot be empty.",
                "Delay after incorrect answer must be a whole number.",
                "Delay after incorrect answer must be in the range 0 - 30000 milliseconds.");
        }

        private bool ValidateDelay(
            TextBox element,
            string errorMessageNullOrEmpty,
            string errorMessageInvalidInt,
            string errorMessageOutOfRange)
        {
            // General int validation
            bool validInt = InputValidator.ValidateTextBoxInt(
                element,
                errorMessageNullOrEmpty,
                errorMessageInvalidInt);

            if (validInt == false)
            {
                return false;
            }

            // Check if value is within range
            int value = int.Parse(element.Text.ToString());

            if (value < 0 || value > 30000)
            {
                InputValidator.AddMessage(errorMessageOutOfRange);
                return false;
            }

            return true;
        }

        private void SaveAppSettings_EventHandler()
        {
            if (ValidateInput() == false)
            {
                MessageBox.Show(
                    InputValidator.GetMessages(),
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            else
            {
                AppSettings.DelayBeforePromptingNextQuestionAfterCorrectAnswer =
                    int.Parse(textBoxDelayBeforePromptCorrect.Text);

                AppSettings.DelayBeforePromptingNextQuestionAfterIncorrectAnswer =
                    int.Parse(textBoxDelayBeforePromptIncorrect.Text);
            }

            DialogResult = DialogResult.Yes;
            this.Close();
        }





        /**
         * 
         * ===================  Events  ===================
         * 
         */

        private void btnLanguageEnglish_Click(object sender, EventArgs e)
        {
            AppSettings.AppLanguage = AppLanguages.English;
            UpdateGUIAccordingToAppSettings();
        }

        private void btnLanguageSwedish_Click(object sender, EventArgs e)
        {
            AppSettings.AppLanguage = AppLanguages.Swedish;
            UpdateGUIAccordingToAppSettings();
        }

        private void btnAutoPromptCorrectYes_Click(object sender, EventArgs e)
        {
            AppSettings.AutoPromptQuestionAfterCorrectAnswer = true;
            UpdateGUIAccordingToAppSettings();
            ToggleDelayBeforePromptCorrect(true);
        }

        private void btnAutoPromptCorrectNo_Click(object sender, EventArgs e)
        {
            AppSettings.AutoPromptQuestionAfterCorrectAnswer = false;
            UpdateGUIAccordingToAppSettings();
            ToggleDelayBeforePromptCorrect(false);
        }

        private void btnAutoPromptIncorrectYes_Click(object sender, EventArgs e)
        {
            AppSettings.AutoPromptQuestionAfterIncorrectAnswer = true;
            UpdateGUIAccordingToAppSettings();
            ToggleDelayBeforePromptIncorrect(true);
        }

        private void btnAutoPromptIncorrectNo_Click(object sender, EventArgs e)
        {
            AppSettings.AutoPromptQuestionAfterIncorrectAnswer = false;
            UpdateGUIAccordingToAppSettings();
            ToggleDelayBeforePromptIncorrect(false);
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveAppSettings_EventHandler();
        }
    }
}
