
namespace WinformUI
{
    partial class FormAppSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSettingsHeading = new System.Windows.Forms.Label();
            this.btnLanguageSwedish = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblDelayBeforePrompt = new System.Windows.Forms.Label();
            this.lblDelayBeforePromptCorrect = new System.Windows.Forms.Label();
            this.lblAutoPrompt = new System.Windows.Forms.Label();
            this.btnAutoPromptCorrectYes = new System.Windows.Forms.Button();
            this.btnAutoPromptCorrectNo = new System.Windows.Forms.Button();
            this.btnLanguageEnglish = new System.Windows.Forms.Button();
            this.lblAutoPromptCorrect = new System.Windows.Forms.Label();
            this.btnAutoPromptIncorrectYes = new System.Windows.Forms.Button();
            this.lblAutoPromptIncorrect = new System.Windows.Forms.Label();
            this.btnAutoPromptIncorrectNo = new System.Windows.Forms.Button();
            this.textBoxDelayBeforePromptCorrect = new System.Windows.Forms.TextBox();
            this.textBoxDelayBeforePromptIncorrect = new System.Windows.Forms.TextBox();
            this.lblDelayBeforePromptIncorrect = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSettingsHeading
            // 
            this.lblSettingsHeading.AutoSize = true;
            this.lblSettingsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsHeading.Location = new System.Drawing.Point(32, 26);
            this.lblSettingsHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSettingsHeading.Name = "lblSettingsHeading";
            this.lblSettingsHeading.Size = new System.Drawing.Size(119, 32);
            this.lblSettingsHeading.TabIndex = 1;
            this.lblSettingsHeading.Text = "Settings";
            // 
            // btnLanguageSwedish
            // 
            this.btnLanguageSwedish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLanguageSwedish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLanguageSwedish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanguageSwedish.FlatAppearance.BorderSize = 0;
            this.btnLanguageSwedish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnLanguageSwedish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguageSwedish.Location = new System.Drawing.Point(138, 97);
            this.btnLanguageSwedish.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguageSwedish.Name = "btnLanguageSwedish";
            this.btnLanguageSwedish.Size = new System.Drawing.Size(100, 36);
            this.btnLanguageSwedish.TabIndex = 3;
            this.btnLanguageSwedish.Text = "Svenska";
            this.btnLanguageSwedish.UseVisualStyleBackColor = false;
            this.btnLanguageSwedish.Click += new System.EventHandler(this.btnLanguageSwedish_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(34, 69);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(95, 24);
            this.lblLanguage.TabIndex = 4;
            this.lblLanguage.Text = "Language";
            // 
            // lblDelayBeforePrompt
            // 
            this.lblDelayBeforePrompt.AutoSize = true;
            this.lblDelayBeforePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelayBeforePrompt.Location = new System.Drawing.Point(34, 341);
            this.lblDelayBeforePrompt.Name = "lblDelayBeforePrompt";
            this.lblDelayBeforePrompt.Size = new System.Drawing.Size(435, 24);
            this.lblDelayBeforePrompt.TabIndex = 6;
            this.lblDelayBeforePrompt.Text = "Delay before prompting next word (in milliseconds)";
            // 
            // lblDelayBeforePromptCorrect
            // 
            this.lblDelayBeforePromptCorrect.AutoSize = true;
            this.lblDelayBeforePromptCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelayBeforePromptCorrect.Location = new System.Drawing.Point(52, 372);
            this.lblDelayBeforePromptCorrect.Name = "lblDelayBeforePromptCorrect";
            this.lblDelayBeforePromptCorrect.Size = new System.Drawing.Size(186, 20);
            this.lblDelayBeforePromptCorrect.TabIndex = 7;
            this.lblDelayBeforePromptCorrect.Text = "After correct translation";
            // 
            // lblAutoPrompt
            // 
            this.lblAutoPrompt.AutoSize = true;
            this.lblAutoPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoPrompt.Location = new System.Drawing.Point(34, 156);
            this.lblAutoPrompt.Name = "lblAutoPrompt";
            this.lblAutoPrompt.Size = new System.Drawing.Size(270, 24);
            this.lblAutoPrompt.TabIndex = 9;
            this.lblAutoPrompt.Text = "Prompt next word automatically";
            // 
            // btnAutoPromptCorrectYes
            // 
            this.btnAutoPromptCorrectYes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAutoPromptCorrectYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoPromptCorrectYes.FlatAppearance.BorderSize = 0;
            this.btnAutoPromptCorrectYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPromptCorrectYes.ForeColor = System.Drawing.Color.White;
            this.btnAutoPromptCorrectYes.Location = new System.Drawing.Point(55, 209);
            this.btnAutoPromptCorrectYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutoPromptCorrectYes.Name = "btnAutoPromptCorrectYes";
            this.btnAutoPromptCorrectYes.Size = new System.Drawing.Size(100, 36);
            this.btnAutoPromptCorrectYes.TabIndex = 2;
            this.btnAutoPromptCorrectYes.Text = "Yes";
            this.btnAutoPromptCorrectYes.UseVisualStyleBackColor = false;
            this.btnAutoPromptCorrectYes.Click += new System.EventHandler(this.btnAutoPromptCorrectYes_Click);
            // 
            // btnAutoPromptCorrectNo
            // 
            this.btnAutoPromptCorrectNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAutoPromptCorrectNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoPromptCorrectNo.FlatAppearance.BorderSize = 0;
            this.btnAutoPromptCorrectNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAutoPromptCorrectNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPromptCorrectNo.Location = new System.Drawing.Point(155, 209);
            this.btnAutoPromptCorrectNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutoPromptCorrectNo.Name = "btnAutoPromptCorrectNo";
            this.btnAutoPromptCorrectNo.Size = new System.Drawing.Size(100, 36);
            this.btnAutoPromptCorrectNo.TabIndex = 3;
            this.btnAutoPromptCorrectNo.Text = "No";
            this.btnAutoPromptCorrectNo.UseVisualStyleBackColor = false;
            this.btnAutoPromptCorrectNo.Click += new System.EventHandler(this.btnAutoPromptCorrectNo_Click);
            // 
            // btnLanguageEnglish
            // 
            this.btnLanguageEnglish.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLanguageEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanguageEnglish.FlatAppearance.BorderSize = 0;
            this.btnLanguageEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguageEnglish.ForeColor = System.Drawing.Color.White;
            this.btnLanguageEnglish.Location = new System.Drawing.Point(38, 97);
            this.btnLanguageEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguageEnglish.Name = "btnLanguageEnglish";
            this.btnLanguageEnglish.Size = new System.Drawing.Size(100, 36);
            this.btnLanguageEnglish.TabIndex = 2;
            this.btnLanguageEnglish.Text = "English";
            this.btnLanguageEnglish.UseVisualStyleBackColor = false;
            this.btnLanguageEnglish.Click += new System.EventHandler(this.btnLanguageEnglish_Click);
            // 
            // lblAutoPromptCorrect
            // 
            this.lblAutoPromptCorrect.AutoSize = true;
            this.lblAutoPromptCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoPromptCorrect.Location = new System.Drawing.Point(52, 185);
            this.lblAutoPromptCorrect.Name = "lblAutoPromptCorrect";
            this.lblAutoPromptCorrect.Size = new System.Drawing.Size(186, 20);
            this.lblAutoPromptCorrect.TabIndex = 10;
            this.lblAutoPromptCorrect.Text = "After correct translation";
            // 
            // btnAutoPromptIncorrectYes
            // 
            this.btnAutoPromptIncorrectYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAutoPromptIncorrectYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoPromptIncorrectYes.FlatAppearance.BorderSize = 0;
            this.btnAutoPromptIncorrectYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.btnAutoPromptIncorrectYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPromptIncorrectYes.ForeColor = System.Drawing.Color.Black;
            this.btnAutoPromptIncorrectYes.Location = new System.Drawing.Point(55, 282);
            this.btnAutoPromptIncorrectYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutoPromptIncorrectYes.Name = "btnAutoPromptIncorrectYes";
            this.btnAutoPromptIncorrectYes.Size = new System.Drawing.Size(100, 36);
            this.btnAutoPromptIncorrectYes.TabIndex = 11;
            this.btnAutoPromptIncorrectYes.Text = "Yes";
            this.btnAutoPromptIncorrectYes.UseVisualStyleBackColor = false;
            this.btnAutoPromptIncorrectYes.Click += new System.EventHandler(this.btnAutoPromptIncorrectYes_Click);
            // 
            // lblAutoPromptIncorrect
            // 
            this.lblAutoPromptIncorrect.AutoSize = true;
            this.lblAutoPromptIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoPromptIncorrect.Location = new System.Drawing.Point(52, 258);
            this.lblAutoPromptIncorrect.Name = "lblAutoPromptIncorrect";
            this.lblAutoPromptIncorrect.Size = new System.Drawing.Size(199, 20);
            this.lblAutoPromptIncorrect.TabIndex = 13;
            this.lblAutoPromptIncorrect.Text = "After incorrect translation";
            // 
            // btnAutoPromptIncorrectNo
            // 
            this.btnAutoPromptIncorrectNo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAutoPromptIncorrectNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoPromptIncorrectNo.FlatAppearance.BorderSize = 0;
            this.btnAutoPromptIncorrectNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAutoPromptIncorrectNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPromptIncorrectNo.ForeColor = System.Drawing.Color.White;
            this.btnAutoPromptIncorrectNo.Location = new System.Drawing.Point(155, 282);
            this.btnAutoPromptIncorrectNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutoPromptIncorrectNo.Name = "btnAutoPromptIncorrectNo";
            this.btnAutoPromptIncorrectNo.Size = new System.Drawing.Size(100, 36);
            this.btnAutoPromptIncorrectNo.TabIndex = 12;
            this.btnAutoPromptIncorrectNo.Text = "No";
            this.btnAutoPromptIncorrectNo.UseVisualStyleBackColor = false;
            this.btnAutoPromptIncorrectNo.Click += new System.EventHandler(this.btnAutoPromptIncorrectNo_Click);
            // 
            // textBoxDelayBeforePromptCorrect
            // 
            this.textBoxDelayBeforePromptCorrect.Location = new System.Drawing.Point(56, 395);
            this.textBoxDelayBeforePromptCorrect.Name = "textBoxDelayBeforePromptCorrect";
            this.textBoxDelayBeforePromptCorrect.Size = new System.Drawing.Size(182, 27);
            this.textBoxDelayBeforePromptCorrect.TabIndex = 14;
            this.textBoxDelayBeforePromptCorrect.Text = "1500";
            // 
            // textBoxDelayBeforePromptIncorrect
            // 
            this.textBoxDelayBeforePromptIncorrect.Enabled = false;
            this.textBoxDelayBeforePromptIncorrect.Location = new System.Drawing.Point(55, 459);
            this.textBoxDelayBeforePromptIncorrect.Name = "textBoxDelayBeforePromptIncorrect";
            this.textBoxDelayBeforePromptIncorrect.Size = new System.Drawing.Size(182, 27);
            this.textBoxDelayBeforePromptIncorrect.TabIndex = 16;
            this.textBoxDelayBeforePromptIncorrect.Text = "5000";
            // 
            // lblDelayBeforePromptIncorrect
            // 
            this.lblDelayBeforePromptIncorrect.AutoSize = true;
            this.lblDelayBeforePromptIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelayBeforePromptIncorrect.Location = new System.Drawing.Point(51, 435);
            this.lblDelayBeforePromptIncorrect.Name = "lblDelayBeforePromptIncorrect";
            this.lblDelayBeforePromptIncorrect.Size = new System.Drawing.Size(199, 20);
            this.lblDelayBeforePromptIncorrect.TabIndex = 15;
            this.lblDelayBeforePromptIncorrect.Text = "After incorrect translation";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.Location = new System.Drawing.Point(188, 510);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(250, 50);
            this.btnSaveSettings.TabIndex = 17;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // FormAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 580);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.textBoxDelayBeforePromptIncorrect);
            this.Controls.Add(this.lblDelayBeforePromptIncorrect);
            this.Controls.Add(this.textBoxDelayBeforePromptCorrect);
            this.Controls.Add(this.btnAutoPromptIncorrectYes);
            this.Controls.Add(this.lblAutoPromptIncorrect);
            this.Controls.Add(this.btnAutoPromptIncorrectNo);
            this.Controls.Add(this.btnAutoPromptCorrectYes);
            this.Controls.Add(this.lblAutoPromptCorrect);
            this.Controls.Add(this.btnAutoPromptCorrectNo);
            this.Controls.Add(this.btnLanguageEnglish);
            this.Controls.Add(this.btnLanguageSwedish);
            this.Controls.Add(this.lblAutoPrompt);
            this.Controls.Add(this.lblDelayBeforePromptCorrect);
            this.Controls.Add(this.lblDelayBeforePrompt);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblSettingsHeading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAppSettings";
            this.Text = "UpVocabulary - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettingsHeading;
        private System.Windows.Forms.Button btnLanguageSwedish;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblDelayBeforePrompt;
        private System.Windows.Forms.Label lblDelayBeforePromptCorrect;
        private System.Windows.Forms.Label lblAutoPrompt;
        private System.Windows.Forms.Button btnAutoPromptCorrectYes;
        private System.Windows.Forms.Button btnAutoPromptCorrectNo;
        private System.Windows.Forms.Button btnLanguageEnglish;
        private System.Windows.Forms.Label lblAutoPromptCorrect;
        private System.Windows.Forms.Button btnAutoPromptIncorrectYes;
        private System.Windows.Forms.Label lblAutoPromptIncorrect;
        private System.Windows.Forms.Button btnAutoPromptIncorrectNo;
        private System.Windows.Forms.TextBox textBoxDelayBeforePromptCorrect;
        private System.Windows.Forms.TextBox textBoxDelayBeforePromptIncorrect;
        private System.Windows.Forms.Label lblDelayBeforePromptIncorrect;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}