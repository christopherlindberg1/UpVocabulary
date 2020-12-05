
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
            this.comboBoxOriginalLanguage = new System.Windows.Forms.ComboBox();
            this.comboBoxTranslationLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWordTitle = new System.Windows.Forms.Label();
            this.lblWordInLang1 = new System.Windows.Forms.Label();
            this.textBoxWordInOriginalLanguage = new System.Windows.Forms.TextBox();
            this.textBoxWordTranslationToOtherLanguage = new System.Windows.Forms.TextBox();
            this.lblTranslationOfWord = new System.Windows.Forms.Label();
            this.textBoxWordUsedInSentence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveWord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveVocabulary = new System.Windows.Forms.Button();
            this.lblWordList = new System.Windows.Forms.Label();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.btnRemoveWords = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            // comboBoxOriginalLanguage
            // 
            this.comboBoxOriginalLanguage.FormattingEnabled = true;
            this.comboBoxOriginalLanguage.Location = new System.Drawing.Point(35, 148);
            this.comboBoxOriginalLanguage.Name = "comboBoxOriginalLanguage";
            this.comboBoxOriginalLanguage.Size = new System.Drawing.Size(135, 24);
            this.comboBoxOriginalLanguage.TabIndex = 4;
            // 
            // comboBoxTranslationLanguage
            // 
            this.comboBoxTranslationLanguage.FormattingEnabled = true;
            this.comboBoxTranslationLanguage.Location = new System.Drawing.Point(224, 148);
            this.comboBoxTranslationLanguage.Name = "comboBoxTranslationLanguage";
            this.comboBoxTranslationLanguage.Size = new System.Drawing.Size(135, 24);
            this.comboBoxTranslationLanguage.TabIndex = 5;
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
            this.lblWordTitle.Size = new System.Drawing.Size(116, 29);
            this.lblWordTitle.TabIndex = 8;
            this.lblWordTitle.Text = "Add word";
            // 
            // lblWordInLang1
            // 
            this.lblWordInLang1.AutoSize = true;
            this.lblWordInLang1.Location = new System.Drawing.Point(34, 249);
            this.lblWordInLang1.Name = "lblWordInLang1";
            this.lblWordInLang1.Size = new System.Drawing.Size(170, 17);
            this.lblWordInLang1.TabIndex = 9;
            this.lblWordInLang1.Text = "Word in original language";
            // 
            // textBoxWordInOriginalLanguage
            // 
            this.textBoxWordInOriginalLanguage.Location = new System.Drawing.Point(37, 269);
            this.textBoxWordInOriginalLanguage.Name = "textBoxWordInOriginalLanguage";
            this.textBoxWordInOriginalLanguage.Size = new System.Drawing.Size(133, 22);
            this.textBoxWordInOriginalLanguage.TabIndex = 10;
            // 
            // textBoxWordTranslationToOtherLanguage
            // 
            this.textBoxWordTranslationToOtherLanguage.Location = new System.Drawing.Point(37, 328);
            this.textBoxWordTranslationToOtherLanguage.Name = "textBoxWordTranslationToOtherLanguage";
            this.textBoxWordTranslationToOtherLanguage.Size = new System.Drawing.Size(133, 22);
            this.textBoxWordTranslationToOtherLanguage.TabIndex = 12;
            // 
            // lblTranslationOfWord
            // 
            this.lblTranslationOfWord.AutoSize = true;
            this.lblTranslationOfWord.Location = new System.Drawing.Point(34, 308);
            this.lblTranslationOfWord.Name = "lblTranslationOfWord";
            this.lblTranslationOfWord.Size = new System.Drawing.Size(208, 17);
            this.lblTranslationOfWord.TabIndex = 11;
            this.lblTranslationOfWord.Text = "Translation to second language";
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
            this.btnSaveVocabulary.Location = new System.Drawing.Point(97, 575);
            this.btnSaveVocabulary.Name = "btnSaveVocabulary";
            this.btnSaveVocabulary.Size = new System.Drawing.Size(262, 73);
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
            this.listBoxWords.Location = new System.Drawing.Point(518, 90);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxWords.Size = new System.Drawing.Size(248, 356);
            this.listBoxWords.TabIndex = 19;
            this.listBoxWords.SelectedIndexChanged += new System.EventHandler(this.listBoxWords_SelectedIndexChanged);
            // 
            // btnRemoveWords
            // 
            this.btnRemoveWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveWords.Location = new System.Drawing.Point(567, 475);
            this.btnRemoveWords.Name = "btnRemoveWords";
            this.btnRemoveWords.Size = new System.Drawing.Size(150, 35);
            this.btnRemoveWords.TabIndex = 20;
            this.btnRemoveWords.Text = "Remove";
            this.btnRemoveWords.UseVisualStyleBackColor = true;
            this.btnRemoveWords.Click += new System.EventHandler(this.btnRemoveWords_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(431, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(262, 73);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormCreateAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 681);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveWords);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.lblWordList);
            this.Controls.Add(this.btnSaveVocabulary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveWord);
            this.Controls.Add(this.textBoxWordUsedInSentence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWordTranslationToOtherLanguage);
            this.Controls.Add(this.lblTranslationOfWord);
            this.Controls.Add(this.textBoxWordInOriginalLanguage);
            this.Controls.Add(this.lblWordInLang1);
            this.Controls.Add(this.lblWordTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTranslationLanguage);
            this.Controls.Add(this.comboBoxOriginalLanguage);
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
        private System.Windows.Forms.ComboBox comboBoxOriginalLanguage;
        private System.Windows.Forms.ComboBox comboBoxTranslationLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWordTitle;
        private System.Windows.Forms.Label lblWordInLang1;
        private System.Windows.Forms.TextBox textBoxWordInOriginalLanguage;
        private System.Windows.Forms.TextBox textBoxWordTranslationToOtherLanguage;
        private System.Windows.Forms.Label lblTranslationOfWord;
        private System.Windows.Forms.TextBox textBoxWordUsedInSentence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveVocabulary;
        private System.Windows.Forms.Label lblWordList;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Button btnRemoveWords;
        private System.Windows.Forms.Button btnCancel;
    }
}