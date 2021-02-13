
namespace WinformUI
{
    partial class FormPracticeSettings
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
            this.lblLanguages = new System.Windows.Forms.Label();
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAmountOfWords = new System.Windows.Forms.Label();
            this.comboBoxNrOfWords = new System.Windows.Forms.ComboBox();
            this.btnStartPractice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(25, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(285, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Configure your practice session";
            // 
            // lblLanguages
            // 
            this.lblLanguages.AutoSize = true;
            this.lblLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguages.Location = new System.Drawing.Point(30, 123);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(82, 20);
            this.lblLanguages.TabIndex = 1;
            this.lblLanguages.Text = "Language";
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Location = new System.Drawing.Point(34, 146);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size(248, 28);
            this.comboBoxLanguages.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(30, 64);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(543, 59);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Configure your practice session for [Vocabulary title]";
            // 
            // lblAmountOfWords
            // 
            this.lblAmountOfWords.AutoSize = true;
            this.lblAmountOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfWords.Location = new System.Drawing.Point(31, 182);
            this.lblAmountOfWords.Name = "lblAmountOfWords";
            this.lblAmountOfWords.Size = new System.Drawing.Size(135, 20);
            this.lblAmountOfWords.TabIndex = 4;
            this.lblAmountOfWords.Text = "Amount of words";
            // 
            // comboBoxNrOfWords
            // 
            this.comboBoxNrOfWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNrOfWords.FormattingEnabled = true;
            this.comboBoxNrOfWords.Location = new System.Drawing.Point(34, 205);
            this.comboBoxNrOfWords.Name = "comboBoxNrOfWords";
            this.comboBoxNrOfWords.Size = new System.Drawing.Size(153, 28);
            this.comboBoxNrOfWords.TabIndex = 5;
            // 
            // btnStartPractice
            // 
            this.btnStartPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPractice.Location = new System.Drawing.Point(34, 266);
            this.btnStartPractice.Name = "btnStartPractice";
            this.btnStartPractice.Size = new System.Drawing.Size(250, 50);
            this.btnStartPractice.TabIndex = 6;
            this.btnStartPractice.Text = "Start practice";
            this.btnStartPractice.UseVisualStyleBackColor = true;
            this.btnStartPractice.Click += new System.EventHandler(this.btnStartPractice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(323, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(250, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormPracticeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 349);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStartPractice);
            this.Controls.Add(this.comboBoxNrOfWords);
            this.Controls.Add(this.lblAmountOfWords);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.comboBoxLanguages);
            this.Controls.Add(this.lblLanguages);
            this.Controls.Add(this.lblHeading);
            this.Name = "FormPracticeSettings";
            this.Text = "UpVocabulary - Practice settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.ComboBox comboBoxLanguages;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmountOfWords;
        private System.Windows.Forms.ComboBox comboBoxNrOfWords;
        private System.Windows.Forms.Button btnStartPractice;
        private System.Windows.Forms.Button btnCancel;
    }
}