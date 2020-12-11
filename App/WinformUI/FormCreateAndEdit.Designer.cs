
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
            this.lblWordInOriginalLanguage = new System.Windows.Forms.Label();
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
            this.btnCancelWordEditing = new System.Windows.Forms.Button();
            this.listBoxTranslations = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveTranslation = new System.Windows.Forms.Button();
            this.btnAddTranslation = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.textBoxNameOfVocabulary.Location = new System.Drawing.Point(35, 90);
            this.textBoxNameOfVocabulary.Name = "textBoxNameOfVocabulary";
            this.textBoxNameOfVocabulary.Size = new System.Drawing.Size(324, 27);
            this.textBoxNameOfVocabulary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Languages";
            // 
            // comboBoxOriginalLanguage
            // 
            this.comboBoxOriginalLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOriginalLanguage.FormattingEnabled = true;
            this.comboBoxOriginalLanguage.Location = new System.Drawing.Point(35, 148);
            this.comboBoxOriginalLanguage.Name = "comboBoxOriginalLanguage";
            this.comboBoxOriginalLanguage.Size = new System.Drawing.Size(135, 28);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Word used in sentence (optional)";
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
            // listBoxTranslations
            // 
            this.listBoxTranslations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTranslations.FormattingEnabled = true;
            this.listBoxTranslations.ItemHeight = 20;
            this.listBoxTranslations.Location = new System.Drawing.Point(469, 270);
            this.listBoxTranslations.Name = "listBoxTranslations";
            this.listBoxTranslations.Size = new System.Drawing.Size(199, 244);
            this.listBoxTranslations.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Translations of [Word]";
            // 
            // btnRemoveTranslation
            // 
            this.btnRemoveTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTranslation.Location = new System.Drawing.Point(517, 520);
            this.btnRemoveTranslation.Name = "btnRemoveTranslation";
            this.btnRemoveTranslation.Size = new System.Drawing.Size(100, 32);
            this.btnRemoveTranslation.TabIndex = 26;
            this.btnRemoveTranslation.Text = "Remove";
            this.btnRemoveTranslation.UseVisualStyleBackColor = true;
            // 
            // btnAddTranslation
            // 
            this.btnAddTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTranslation.Location = new System.Drawing.Point(229, 326);
            this.btnAddTranslation.Name = "btnAddTranslation";
            this.btnAddTranslation.Size = new System.Drawing.Size(75, 32);
            this.btnAddTranslation.TabIndex = 27;
            this.btnAddTranslation.Text = "Add";
            this.btnAddTranslation.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Word class";
            // 
            // FormCreateAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 742);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAddTranslation);
            this.Controls.Add(this.btnRemoveTranslation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxTranslations);
            this.Controls.Add(this.btnCancelWordEditing);
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
            this.Controls.Add(this.lblWordInOriginalLanguage);
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
        private System.Windows.Forms.Label lblWordInOriginalLanguage;
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
        private System.Windows.Forms.Button btnCancelWordEditing;
        private System.Windows.Forms.ListBox listBoxTranslations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveTranslation;
        private System.Windows.Forms.Button btnAddTranslation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}