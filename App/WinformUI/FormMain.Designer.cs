
namespace WinformUI
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewVocabularies = new System.Windows.Forms.ListView();
            this.listViewVocabularies_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewVocabularies_NrOfWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewVocabularies_Languages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateNewVocabulary = new System.Windows.Forms.Button();
            this.btnStartPractice = new System.Windows.Forms.Button();
            this.btnEditVocabulary = new System.Windows.Forms.Button();
            this.btnRemoveVocabulary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your vocabularies";
            // 
            // listViewVocabularies
            // 
            this.listViewVocabularies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewVocabularies_Name,
            this.listViewVocabularies_NrOfWords,
            this.listViewVocabularies_Languages});
            this.listViewVocabularies.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewVocabularies.HideSelection = false;
            this.listViewVocabularies.Location = new System.Drawing.Point(33, 77);
            this.listViewVocabularies.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.listViewVocabularies.Name = "listViewVocabularies";
            this.listViewVocabularies.Size = new System.Drawing.Size(634, 263);
            this.listViewVocabularies.TabIndex = 1;
            this.listViewVocabularies.UseCompatibleStateImageBehavior = false;
            this.listViewVocabularies.View = System.Windows.Forms.View.Details;
            this.listViewVocabularies.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewVocabularies_ItemSelectionChanged);
            // 
            // listViewVocabularies_Name
            // 
            this.listViewVocabularies_Name.Text = "Vocabulary Name";
            this.listViewVocabularies_Name.Width = 225;
            // 
            // listViewVocabularies_NrOfWords
            // 
            this.listViewVocabularies_NrOfWords.Text = "Nr of words";
            this.listViewVocabularies_NrOfWords.Width = 100;
            // 
            // listViewVocabularies_Languages
            // 
            this.listViewVocabularies_Languages.Text = "Languages";
            this.listViewVocabularies_Languages.Width = 150;
            // 
            // btnCreateNewVocabulary
            // 
            this.btnCreateNewVocabulary.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateNewVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewVocabulary.Location = new System.Drawing.Point(185, 368);
            this.btnCreateNewVocabulary.Name = "btnCreateNewVocabulary";
            this.btnCreateNewVocabulary.Size = new System.Drawing.Size(308, 60);
            this.btnCreateNewVocabulary.TabIndex = 2;
            this.btnCreateNewVocabulary.Text = "Create new vocabulary";
            this.btnCreateNewVocabulary.UseVisualStyleBackColor = false;
            this.btnCreateNewVocabulary.Click += new System.EventHandler(this.btnCreateNewVocabulary_Click);
            // 
            // btnStartPractice
            // 
            this.btnStartPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPractice.Location = new System.Drawing.Point(703, 120);
            this.btnStartPractice.Name = "btnStartPractice";
            this.btnStartPractice.Size = new System.Drawing.Size(185, 45);
            this.btnStartPractice.TabIndex = 3;
            this.btnStartPractice.Text = "Practice";
            this.btnStartPractice.UseVisualStyleBackColor = true;
            this.btnStartPractice.Click += new System.EventHandler(this.btnStartPractice_Click);
            // 
            // btnEditVocabulary
            // 
            this.btnEditVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVocabulary.Location = new System.Drawing.Point(703, 189);
            this.btnEditVocabulary.Name = "btnEditVocabulary";
            this.btnEditVocabulary.Size = new System.Drawing.Size(185, 45);
            this.btnEditVocabulary.TabIndex = 4;
            this.btnEditVocabulary.Text = "Edit";
            this.btnEditVocabulary.UseVisualStyleBackColor = true;
            this.btnEditVocabulary.Click += new System.EventHandler(this.btnEditVocabulary_Click);
            // 
            // btnRemoveVocabulary
            // 
            this.btnRemoveVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveVocabulary.Location = new System.Drawing.Point(703, 258);
            this.btnRemoveVocabulary.Name = "btnRemoveVocabulary";
            this.btnRemoveVocabulary.Size = new System.Drawing.Size(185, 45);
            this.btnRemoveVocabulary.TabIndex = 5;
            this.btnRemoveVocabulary.Text = "Remove";
            this.btnRemoveVocabulary.UseVisualStyleBackColor = true;
            this.btnRemoveVocabulary.Click += new System.EventHandler(this.btnRemoveVocabulary_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.btnRemoveVocabulary);
            this.Controls.Add(this.btnEditVocabulary);
            this.Controls.Add(this.btnStartPractice);
            this.Controls.Add(this.btnCreateNewVocabulary);
            this.Controls.Add(this.listViewVocabularies);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "UpVocabulary";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewVocabularies;
        private System.Windows.Forms.ColumnHeader listViewVocabularies_Name;
        private System.Windows.Forms.ColumnHeader listViewVocabularies_NrOfWords;
        private System.Windows.Forms.ColumnHeader listViewVocabularies_Languages;
        private System.Windows.Forms.Button btnCreateNewVocabulary;
        private System.Windows.Forms.Button btnStartPractice;
        private System.Windows.Forms.Button btnEditVocabulary;
        private System.Windows.Forms.Button btnRemoveVocabulary;
    }
}

