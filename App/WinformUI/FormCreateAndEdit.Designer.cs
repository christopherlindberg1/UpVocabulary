﻿
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
            this.lblLanguages = new System.Windows.Forms.Label();
            this.comboBoxOriginalLanguage = new System.Windows.Forms.ComboBox();
            this.comboBoxTranslationLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguageSwitch = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWordTitle = new System.Windows.Forms.Label();
            this.lblWordInOriginalLanguage = new System.Windows.Forms.Label();
            this.textBoxWordInOriginalLanguage = new System.Windows.Forms.TextBox();
            this.textBoxWordTranslationToOtherLanguage = new System.Windows.Forms.TextBox();
            this.lblTranslationOfWord = new System.Windows.Forms.Label();
            this.textBoxWordUsedInSentence = new System.Windows.Forms.TextBox();
            this.lblWordUsedInSentense = new System.Windows.Forms.Label();
            this.btnSaveWord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveVocabulary = new System.Windows.Forms.Button();
            this.lblWordList = new System.Windows.Forms.Label();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.btnRemoveWords = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelWordEditing = new System.Windows.Forms.Button();
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
            this.lblNameOfVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfVocabulary.Location = new System.Drawing.Point(33, 67);
            this.lblNameOfVocabulary.Name = "lblNameOfVocabulary";
            this.lblNameOfVocabulary.Size = new System.Drawing.Size(185, 20);
            this.lblNameOfVocabulary.TabIndex = 1;
            this.lblNameOfVocabulary.Text = "Name of the vocabulary";
            // 
            // textBoxNameOfVocabulary
            // 
            this.textBoxNameOfVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameOfVocabulary.Location = new System.Drawing.Point(36, 90);
            this.textBoxNameOfVocabulary.Name = "textBoxNameOfVocabulary";
            this.textBoxNameOfVocabulary.Size = new System.Drawing.Size(381, 27);
            this.textBoxNameOfVocabulary.TabIndex = 2;
            // 
            // lblLanguages
            // 
            this.lblLanguages.AutoSize = true;
            this.lblLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguages.Location = new System.Drawing.Point(32, 125);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(91, 20);
            this.lblLanguages.TabIndex = 3;
            this.lblLanguages.Text = "Languages";
            // 
            // comboBoxOriginalLanguage
            // 
            this.comboBoxOriginalLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOriginalLanguage.FormattingEnabled = true;
            this.comboBoxOriginalLanguage.Location = new System.Drawing.Point(37, 148);
            this.comboBoxOriginalLanguage.Name = "comboBoxOriginalLanguage";
            this.comboBoxOriginalLanguage.Size = new System.Drawing.Size(133, 28);
            this.comboBoxOriginalLanguage.TabIndex = 4;
            this.comboBoxOriginalLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxOriginalLanguage_SelectedIndexChanged);
            // 
            // comboBoxTranslationLanguage
            // 
            this.comboBoxTranslationLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTranslationLanguage.FormattingEnabled = true;
            this.comboBoxTranslationLanguage.Location = new System.Drawing.Point(224, 148);
            this.comboBoxTranslationLanguage.Name = "comboBoxTranslationLanguage";
            this.comboBoxTranslationLanguage.Size = new System.Drawing.Size(135, 28);
            this.comboBoxTranslationLanguage.TabIndex = 5;
            this.comboBoxTranslationLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxTranslationLanguage_SelectedIndexChanged);
            // 
            // lblLanguageSwitch
            // 
            this.lblLanguageSwitch.AutoSize = true;
            this.lblLanguageSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguageSwitch.Location = new System.Drawing.Point(189, 151);
            this.lblLanguageSwitch.Name = "lblLanguageSwitch";
            this.lblLanguageSwitch.Size = new System.Drawing.Size(23, 20);
            this.lblLanguageSwitch.TabIndex = 6;
            this.lblLanguageSwitch.Text = "to";
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
            // lblWordInOriginalLanguage
            // 
            this.lblWordInOriginalLanguage.AutoSize = true;
            this.lblWordInOriginalLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordInOriginalLanguage.Location = new System.Drawing.Point(34, 246);
            this.lblWordInOriginalLanguage.Name = "lblWordInOriginalLanguage";
            this.lblWordInOriginalLanguage.Size = new System.Drawing.Size(198, 20);
            this.lblWordInOriginalLanguage.TabIndex = 9;
            this.lblWordInOriginalLanguage.Text = "Word in original language";
            // 
            // textBoxWordInOriginalLanguage
            // 
            this.textBoxWordInOriginalLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWordInOriginalLanguage.Location = new System.Drawing.Point(37, 269);
            this.textBoxWordInOriginalLanguage.Name = "textBoxWordInOriginalLanguage";
            this.textBoxWordInOriginalLanguage.Size = new System.Drawing.Size(181, 27);
            this.textBoxWordInOriginalLanguage.TabIndex = 10;
            // 
            // textBoxWordTranslationToOtherLanguage
            // 
            this.textBoxWordTranslationToOtherLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWordTranslationToOtherLanguage.Location = new System.Drawing.Point(37, 328);
            this.textBoxWordTranslationToOtherLanguage.Name = "textBoxWordTranslationToOtherLanguage";
            this.textBoxWordTranslationToOtherLanguage.Size = new System.Drawing.Size(181, 27);
            this.textBoxWordTranslationToOtherLanguage.TabIndex = 12;
            // 
            // lblTranslationOfWord
            // 
            this.lblTranslationOfWord.AutoSize = true;
            this.lblTranslationOfWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslationOfWord.Location = new System.Drawing.Point(33, 305);
            this.lblTranslationOfWord.Name = "lblTranslationOfWord";
            this.lblTranslationOfWord.Size = new System.Drawing.Size(271, 20);
            this.lblTranslationOfWord.TabIndex = 11;
            this.lblTranslationOfWord.Text = "Add translation to second language";
            // 
            // textBoxWordUsedInSentence
            // 
            this.textBoxWordUsedInSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWordUsedInSentence.Location = new System.Drawing.Point(37, 386);
            this.textBoxWordUsedInSentence.Multiline = true;
            this.textBoxWordUsedInSentence.Name = "textBoxWordUsedInSentence";
            this.textBoxWordUsedInSentence.Size = new System.Drawing.Size(380, 123);
            this.textBoxWordUsedInSentence.TabIndex = 14;
            // 
            // lblWordUsedInSentense
            // 
            this.lblWordUsedInSentense.AutoSize = true;
            this.lblWordUsedInSentense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordUsedInSentense.Location = new System.Drawing.Point(34, 363);
            this.lblWordUsedInSentense.Name = "lblWordUsedInSentense";
            this.lblWordUsedInSentense.Size = new System.Drawing.Size(256, 20);
            this.lblWordUsedInSentense.TabIndex = 13;
            this.lblWordUsedInSentense.Text = "Word used in sentence (optional)";
            // 
            // btnSaveWord
            // 
            this.btnSaveWord.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWord.Location = new System.Drawing.Point(39, 538);
            this.btnSaveWord.Name = "btnSaveWord";
            this.btnSaveWord.Size = new System.Drawing.Size(244, 45);
            this.btnSaveWord.TabIndex = 15;
            this.btnSaveWord.Text = "Save word";
            this.btnSaveWord.UseVisualStyleBackColor = false;
            this.btnSaveWord.Click += new System.EventHandler(this.btnSaveWord_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(37, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(980, 3);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // btnSaveVocabulary
            // 
            this.btnSaveVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVocabulary.Location = new System.Drawing.Point(235, 647);
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
            this.lblWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordList.Location = new System.Drawing.Point(726, 58);
            this.lblWordList.Name = "lblWordList";
            this.lblWordList.Size = new System.Drawing.Size(58, 20);
            this.lblWordList.TabIndex = 18;
            this.lblWordList.Text = "Words";
            // 
            // listBoxWords
            // 
            this.listBoxWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.ItemHeight = 20;
            this.listBoxWords.Location = new System.Drawing.Point(730, 81);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxWords.Size = new System.Drawing.Size(294, 424);
            this.listBoxWords.TabIndex = 19;
            this.listBoxWords.SelectedIndexChanged += new System.EventHandler(this.listBoxWords_SelectedIndexChanged);
            // 
            // btnRemoveWords
            // 
            this.btnRemoveWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveWords.Location = new System.Drawing.Point(802, 538);
            this.btnRemoveWords.Name = "btnRemoveWords";
            this.btnRemoveWords.Size = new System.Drawing.Size(150, 45);
            this.btnRemoveWords.TabIndex = 20;
            this.btnRemoveWords.Text = "Remove";
            this.btnRemoveWords.UseVisualStyleBackColor = true;
            this.btnRemoveWords.Click += new System.EventHandler(this.btnRemoveWords_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(569, 647);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(262, 73);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelWordEditing
            // 
            this.btnCancelWordEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelWordEditing.Location = new System.Drawing.Point(306, 538);
            this.btnCancelWordEditing.Name = "btnCancelWordEditing";
            this.btnCancelWordEditing.Size = new System.Drawing.Size(110, 45);
            this.btnCancelWordEditing.TabIndex = 22;
            this.btnCancelWordEditing.Text = "Cancel";
            this.btnCancelWordEditing.UseVisualStyleBackColor = true;
            this.btnCancelWordEditing.Click += new System.EventHandler(this.btnCancelWordEditing_Click);
            // 
            // FormCreateAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 742);
            this.Controls.Add(this.btnCancelWordEditing);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveWords);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.lblWordList);
            this.Controls.Add(this.btnSaveVocabulary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveWord);
            this.Controls.Add(this.textBoxWordUsedInSentence);
            this.Controls.Add(this.lblWordUsedInSentense);
            this.Controls.Add(this.textBoxWordTranslationToOtherLanguage);
            this.Controls.Add(this.lblTranslationOfWord);
            this.Controls.Add(this.textBoxWordInOriginalLanguage);
            this.Controls.Add(this.lblWordInOriginalLanguage);
            this.Controls.Add(this.lblWordTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLanguageSwitch);
            this.Controls.Add(this.comboBoxTranslationLanguage);
            this.Controls.Add(this.comboBoxOriginalLanguage);
            this.Controls.Add(this.lblLanguages);
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
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.ComboBox comboBoxOriginalLanguage;
        private System.Windows.Forms.ComboBox comboBoxTranslationLanguage;
        private System.Windows.Forms.Label lblLanguageSwitch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWordTitle;
        private System.Windows.Forms.Label lblWordInOriginalLanguage;
        private System.Windows.Forms.TextBox textBoxWordInOriginalLanguage;
        private System.Windows.Forms.TextBox textBoxWordTranslationToOtherLanguage;
        private System.Windows.Forms.Label lblTranslationOfWord;
        private System.Windows.Forms.TextBox textBoxWordUsedInSentence;
        private System.Windows.Forms.Label lblWordUsedInSentense;
        private System.Windows.Forms.Button btnSaveWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveVocabulary;
        private System.Windows.Forms.Label lblWordList;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Button btnRemoveWords;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelWordEditing;
    }
}