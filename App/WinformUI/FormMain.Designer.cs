
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewVocabularies = new System.Windows.Forms.ListView();
            this.listViewVocabularies_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewVocabularies_NrOfWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewVocabularies_Languages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewVocabularies_DateLastUsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateNewVocabulary = new System.Windows.Forms.Button();
            this.btnStartPractice = new System.Windows.Forms.Button();
            this.btnEditVocabulary = new System.Windows.Forms.Button();
            this.btnRemoveVocabularies = new System.Windows.Forms.Button();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
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
            this.listViewVocabularies_Languages,
            this.listViewVocabularies_DateLastUsed});
            this.listViewVocabularies.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewVocabularies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewVocabularies.HideSelection = false;
            this.listViewVocabularies.Location = new System.Drawing.Point(33, 77);
            this.listViewVocabularies.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.listViewVocabularies.Name = "listViewVocabularies";
            this.listViewVocabularies.Size = new System.Drawing.Size(746, 263);
            this.listViewVocabularies.TabIndex = 1;
            this.listViewVocabularies.UseCompatibleStateImageBehavior = false;
            this.listViewVocabularies.View = System.Windows.Forms.View.Details;
            this.listViewVocabularies.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewVocabularies_ItemSelectionChanged);
            this.listViewVocabularies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewVocabularies_MouseDoubleClick);
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
            // listViewVocabularies_DateLastUsed
            // 
            this.listViewVocabularies_DateLastUsed.Text = "Date of last use";
            // 
            // btnCreateNewVocabulary
            // 
            this.btnCreateNewVocabulary.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateNewVocabulary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateNewVocabulary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNewVocabulary.FlatAppearance.BorderSize = 0;
            this.btnCreateNewVocabulary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateNewVocabulary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewVocabulary.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewVocabulary.Location = new System.Drawing.Point(281, 367);
            this.btnCreateNewVocabulary.Name = "btnCreateNewVocabulary";
            this.btnCreateNewVocabulary.Size = new System.Drawing.Size(308, 60);
            this.btnCreateNewVocabulary.TabIndex = 2;
            this.btnCreateNewVocabulary.Text = "Create new vocabulary";
            this.btnCreateNewVocabulary.UseVisualStyleBackColor = false;
            this.btnCreateNewVocabulary.Click += new System.EventHandler(this.btnCreateNewVocabulary_Click);
            // 
            // btnStartPractice
            // 
            this.btnStartPractice.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStartPractice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStartPractice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartPractice.FlatAppearance.BorderSize = 0;
            this.btnStartPractice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStartPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPractice.ForeColor = System.Drawing.Color.White;
            this.btnStartPractice.Location = new System.Drawing.Point(883, 115);
            this.btnStartPractice.Name = "btnStartPractice";
            this.btnStartPractice.Size = new System.Drawing.Size(185, 45);
            this.btnStartPractice.TabIndex = 3;
            this.btnStartPractice.Text = "Practice";
            this.btnStartPractice.UseVisualStyleBackColor = false;
            this.btnStartPractice.Click += new System.EventHandler(this.btnStartPractice_Click);
            // 
            // btnEditVocabulary
            // 
            this.btnEditVocabulary.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditVocabulary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditVocabulary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditVocabulary.FlatAppearance.BorderSize = 0;
            this.btnEditVocabulary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditVocabulary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditVocabulary.ForeColor = System.Drawing.Color.White;
            this.btnEditVocabulary.Location = new System.Drawing.Point(883, 184);
            this.btnEditVocabulary.Name = "btnEditVocabulary";
            this.btnEditVocabulary.Size = new System.Drawing.Size(185, 45);
            this.btnEditVocabulary.TabIndex = 4;
            this.btnEditVocabulary.Text = "Edit";
            this.btnEditVocabulary.UseVisualStyleBackColor = false;
            this.btnEditVocabulary.Click += new System.EventHandler(this.btnEditVocabulary_Click);
            // 
            // btnRemoveVocabularies
            // 
            this.btnRemoveVocabularies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveVocabularies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveVocabularies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveVocabularies.FlatAppearance.BorderSize = 0;
            this.btnRemoveVocabularies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemoveVocabularies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveVocabularies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveVocabularies.ForeColor = System.Drawing.Color.White;
            this.btnRemoveVocabularies.Location = new System.Drawing.Point(883, 253);
            this.btnRemoveVocabularies.Name = "btnRemoveVocabularies";
            this.btnRemoveVocabularies.Size = new System.Drawing.Size(185, 45);
            this.btnRemoveVocabularies.TabIndex = 5;
            this.btnRemoveVocabularies.Text = "Remove";
            this.btnRemoveVocabularies.UseVisualStyleBackColor = false;
            this.btnRemoveVocabularies.Click += new System.EventHandler(this.btnRemoveVocabularies_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSettings.Image")));
            this.pictureBoxSettings.Location = new System.Drawing.Point(1015, 19);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSettings.TabIndex = 6;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 450);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.btnRemoveVocabularies);
            this.Controls.Add(this.btnEditVocabulary);
            this.Controls.Add(this.btnStartPractice);
            this.Controls.Add(this.btnCreateNewVocabulary);
            this.Controls.Add(this.listViewVocabularies);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "UpVocabulary";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
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
        private System.Windows.Forms.Button btnRemoveVocabularies;
        private System.Windows.Forms.ColumnHeader listViewVocabularies_DateLastUsed;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
    }
}

