
namespace WinformUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAddVocabulary = new System.Windows.Forms.Button();
            this.btnVocabularies = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnAddVocabulary);
            this.panelMenu.Controls.Add(this.btnVocabularies);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 703);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 200);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAddVocabulary
            // 
            this.btnAddVocabulary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddVocabulary.FlatAppearance.BorderSize = 0;
            this.btnAddVocabulary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVocabulary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddVocabulary.Image = ((System.Drawing.Image)(resources.GetObject("btnAddVocabulary.Image")));
            this.btnAddVocabulary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVocabulary.Location = new System.Drawing.Point(0, 140);
            this.btnAddVocabulary.Name = "btnAddVocabulary";
            this.btnAddVocabulary.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddVocabulary.Size = new System.Drawing.Size(220, 60);
            this.btnAddVocabulary.TabIndex = 2;
            this.btnAddVocabulary.Text = "  Add vocabulary";
            this.btnAddVocabulary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVocabulary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddVocabulary.UseVisualStyleBackColor = true;
            this.btnAddVocabulary.Click += new System.EventHandler(this.btnAddVocabulary_Click);
            // 
            // btnVocabularies
            // 
            this.btnVocabularies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVocabularies.FlatAppearance.BorderSize = 0;
            this.btnVocabularies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVocabularies.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVocabularies.Image = ((System.Drawing.Image)(resources.GetObject("btnVocabularies.Image")));
            this.btnVocabularies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVocabularies.Location = new System.Drawing.Point(0, 80);
            this.btnVocabularies.Name = "btnVocabularies";
            this.btnVocabularies.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVocabularies.Size = new System.Drawing.Size(220, 60);
            this.btnVocabularies.TabIndex = 1;
            this.btnVocabularies.Text = "  Vocabularies";
            this.btnVocabularies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVocabularies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVocabularies.UseVisualStyleBackColor = true;
            this.btnVocabularies.Click += new System.EventHandler(this.btnVocabularies_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(39, 27);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(136, 25);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "UpVocabulary";
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitlebar.Controls.Add(this.lblTitle);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(220, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(1162, 80);
            this.panelTitlebar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(496, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vocabularies";
            // 
            // panelMainContent
            // 
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(220, 80);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1162, 623);
            this.panelMainContent.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnVocabularies;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAddVocabulary;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelMainContent;
    }
}