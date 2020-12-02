
namespace WinformUI
{
    partial class FormCreateAndEdit
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblNameOfVocabulary = new System.Windows.Forms.Label();
            this.textBoxNameOfVocabulary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLanguage1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguage2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWordTitle = new System.Windows.Forms.Label();
            this.lblWordInLang1 = new System.Windows.Forms.Label();
            this.textBoxWordInLanguage1 = new System.Windows.Forms.TextBox();
            this.textBoxTranslationToLanguage2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWordUsedInSentence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveWord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveVocabulary = new System.Windows.Forms.Button();
            this.lblWordList = new System.Windows.Forms.Label();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(27, 23);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(254, 29);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Vocabulary - set on init";
            // 
            // lblNameOfVocabulary
            // 
            this.lblNameOfVocabulary.AutoSize = true;
            this.lblNameOfVocabulary.Location = new System.Drawing.Point(32, 70);
            this.lblNameOfVocabulary.Name = "lblNameOfVocabulary";
            this.lblNameOfVocabulary.Size = new System.Drawing.Size(158, 17);
            this.lblNameOfVocabulary.TabIndex = 1;
            this.lblNameOfVocabulary.Text = "Name of the vocabulary";
            // 
            // textBoxNameOfVocabulary
            // 
            this.textBoxNameOfVocabulary.Location = new System.Drawing.Point(35, 90);
            this.textBoxNameOfVocabulary.Name = "textBoxNameOfVocabulary";
            this.textBoxNameOfVocabulary.Size = new System.Drawing.Size(240, 22);
            this.textBoxNameOfVocabulary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Languages";
            // 
            // comboBoxLanguage1
            // 
            this.comboBoxLanguage1.FormattingEnabled = true;
            this.comboBoxLanguage1.Location = new System.Drawing.Point(35, 148);
            this.comboBoxLanguage1.Name = "comboBoxLanguage1";
            this.comboBoxLanguage1.Size = new System.Drawing.Size(135, 24);
            this.comboBoxLanguage1.TabIndex = 4;
            // 
            // comboBoxLanguage2
            // 
            this.comboBoxLanguage2.FormattingEnabled = true;
            this.comboBoxLanguage2.Location = new System.Drawing.Point(224, 148);
            this.comboBoxLanguage2.Name = "comboBoxLanguage2";
            this.comboBoxLanguage2.Size = new System.Drawing.Size(135, 24);
            this.comboBoxLanguage2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(29, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 3);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // lblWordTitle
            // 
            this.lblWordTitle.AutoSize = true;
            this.lblWordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordTitle.Location = new System.Drawing.Point(32, 208);
            this.lblWordTitle.Name = "lblWordTitle";
            this.lblWordTitle.Size = new System.Drawing.Size(193, 29);
            this.lblWordTitle.TabIndex = 8;
            this.lblWordTitle.Text = "Word - set on init";
            // 
            // lblWordInLang1
            // 
            this.lblWordInLang1.AutoSize = true;
            this.lblWordInLang1.Location = new System.Drawing.Point(34, 249);
            this.lblWordInLang1.Name = "lblWordInLang1";
            this.lblWordInLang1.Size = new System.Drawing.Size(162, 17);
            this.lblWordInLang1.TabIndex = 9;
            this.lblWordInLang1.Text = "Word in lang - set on init";
            // 
            // textBoxWordInLanguage1
            // 
            this.textBoxWordInLanguage1.Location = new System.Drawing.Point(37, 269);
            this.textBoxWordInLanguage1.Name = "textBoxWordInLanguage1";
            this.textBoxWordInLanguage1.Size = new System.Drawing.Size(133, 22);
            this.textBoxWordInLanguage1.TabIndex = 10;
            // 
            // textBoxTranslationToLanguage2
            // 
            this.textBoxTranslationToLanguage2.Location = new System.Drawing.Point(37, 328);
            this.textBoxTranslationToLanguage2.Name = "textBoxTranslationToLanguage2";
            this.textBoxTranslationToLanguage2.Size = new System.Drawing.Size(133, 22);
            this.textBoxTranslationToLanguage2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Translation to lang - set on init";
            // 
            // textBoxWordUsedInSentence
            // 
            this.textBoxWordUsedInSentence.Location = new System.Drawing.Point(37, 386);
            this.textBoxWordUsedInSentence.Multiline = true;
            this.textBoxWordUsedInSentence.Name = "textBoxWordUsedInSentence";
            this.textBoxWordUsedInSentence.Size = new System.Drawing.Size(322, 63);
            this.textBoxWordUsedInSentence.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Word used in sentence (optional)";
            // 
            // btnSaveWord
            // 
            this.btnSaveWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWord.Location = new System.Drawing.Point(37, 470);
            this.btnSaveWord.Name = "btnSaveWord";
            this.btnSaveWord.Size = new System.Drawing.Size(322, 45);
            this.btnSaveWord.TabIndex = 15;
            this.btnSaveWord.Text = "Save word";
            this.btnSaveWord.UseVisualStyleBackColor = true;
            this.btnSaveWord.Click += new System.EventHandler(this.btnSaveWord_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(29, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(737, 3);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // btnSaveVocabulary
            // 
            this.btnSaveVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVocabulary.Location = new System.Drawing.Point(188, 575);
            this.btnSaveVocabulary.Name = "btnSaveVocabulary";
            this.btnSaveVocabulary.Size = new System.Drawing.Size(399, 73);
            this.btnSaveVocabulary.TabIndex = 17;
            this.btnSaveVocabulary.Text = "Save vocabulary";
            this.btnSaveVocabulary.UseVisualStyleBackColor = true;
            this.btnSaveVocabulary.Click += new System.EventHandler(this.btnSaveVocabulary_Click);
            // 
            // lblWordList
            // 
            this.lblWordList.AutoSize = true;
            this.lblWordList.Location = new System.Drawing.Point(519, 70);
            this.lblWordList.Name = "lblWordList";
            this.lblWordList.Size = new System.Drawing.Size(49, 17);
            this.lblWordList.TabIndex = 18;
            this.lblWordList.Text = "Words";
            // 
            // listBoxWords
            // 
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.ItemHeight = 16;
            this.listBoxWords.Items.AddRange(new object[] {
            "Hello - Hej",
            "Yes - Ja"});
            this.listBoxWords.Location = new System.Drawing.Point(518, 90);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(248, 324);
            this.listBoxWords.TabIndex = 19;
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWord.Location = new System.Drawing.Point(567, 433);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(150, 35);
            this.btnDeleteWord.TabIndex = 20;
            this.btnDeleteWord.Text = "Delete word";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            // 
            // FormCreateAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 681);
            this.Controls.Add(this.btnDeleteWord);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.lblWordList);
            this.Controls.Add(this.btnSaveVocabulary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveWord);
            this.Controls.Add(this.textBoxWordUsedInSentence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTranslationToLanguage2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWordInLanguage1);
            this.Controls.Add(this.lblWordInLang1);
            this.Controls.Add(this.lblWordTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLanguage2);
            this.Controls.Add(this.comboBoxLanguage1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameOfVocabulary);
            this.Controls.Add(this.lblNameOfVocabulary);
            this.Controls.Add(this.lblHeading);
            this.Name = "FormCreateAndEdit";
            this.Text = "UpVocabulary - [Set on init]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblNameOfVocabulary;
        private System.Windows.Forms.TextBox textBoxNameOfVocabulary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLanguage1;
        private System.Windows.Forms.ComboBox comboBoxLanguage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWordTitle;
        private System.Windows.Forms.Label lblWordInLang1;
        private System.Windows.Forms.TextBox textBoxWordInLanguage1;
        private System.Windows.Forms.TextBox textBoxTranslationToLanguage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWordUsedInSentence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveVocabulary;
        private System.Windows.Forms.Label lblWordList;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Button btnDeleteWord;
    }
}