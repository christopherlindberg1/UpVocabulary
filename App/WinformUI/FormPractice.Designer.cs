
namespace WinformUI
{
    partial class FormPractice
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblWordToTranslate = new System.Windows.Forms.Label();
            this.lblToggleShowSentence = new System.Windows.Forms.Label();
            this.lblWordUsedInSentence = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.lblToggleScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNrOfCorrectAnswers = new System.Windows.Forms.Label();
            this.lblCorrectOrWrong = new System.Windows.Forms.Label();
            this.btnEndPractice = new System.Windows.Forms.Button();
            this.groupBoxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(27, 27);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(295, 29);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Words from list - set on init";
            // 
            // lblWordToTranslate
            // 
            this.lblWordToTranslate.AutoSize = true;
            this.lblWordToTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordToTranslate.Location = new System.Drawing.Point(32, 78);
            this.lblWordToTranslate.Name = "lblWordToTranslate";
            this.lblWordToTranslate.Size = new System.Drawing.Size(315, 20);
            this.lblWordToTranslate.TabIndex = 1;
            this.lblWordToTranslate.Text = "Translate [word] to [translationLanguage]";
            // 
            // lblToggleShowSentence
            // 
            this.lblToggleShowSentence.AutoSize = true;
            this.lblToggleShowSentence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblToggleShowSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleShowSentence.Location = new System.Drawing.Point(32, 117);
            this.lblToggleShowSentence.Name = "lblToggleShowSentence";
            this.lblToggleShowSentence.Size = new System.Drawing.Size(247, 20);
            this.lblToggleShowSentence.TabIndex = 2;
            this.lblToggleShowSentence.Text = "Show [word] used in a sentence";
            this.lblToggleShowSentence.Click += new System.EventHandler(this.lblToggleShowSentence_Click);
            // 
            // lblWordUsedInSentence
            // 
            this.lblWordUsedInSentence.AutoSize = true;
            this.lblWordUsedInSentence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWordUsedInSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordUsedInSentence.Location = new System.Drawing.Point(51, 146);
            this.lblWordUsedInSentence.Name = "lblWordUsedInSentence";
            this.lblWordUsedInSentence.Size = new System.Drawing.Size(191, 20);
            this.lblWordUsedInSentence.TabIndex = 3;
            this.lblWordUsedInSentence.Text = "[Word used in sentence]";
            // 
            // lblTranslation
            // 
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslation.Location = new System.Drawing.Point(28, 226);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(126, 20);
            this.lblTranslation.TabIndex = 4;
            this.lblTranslation.Text = "Your translation";
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTranslation.Location = new System.Drawing.Point(32, 249);
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.Size = new System.Drawing.Size(247, 27);
            this.textBoxTranslation.TabIndex = 5;
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.lblNrOfCorrectAnswers);
            this.groupBoxScore.Controls.Add(this.label1);
            this.groupBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxScore.Location = new System.Drawing.Point(442, 68);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(310, 126);
            this.groupBoxScore.TabIndex = 6;
            this.groupBoxScore.TabStop = false;
            // 
            // lblToggleScore
            // 
            this.lblToggleScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblToggleScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleScore.Location = new System.Drawing.Point(620, 33);
            this.lblToggleScore.Name = "lblToggleScore";
            this.lblToggleScore.Size = new System.Drawing.Size(132, 23);
            this.lblToggleScore.TabIndex = 7;
            this.lblToggleScore.Text = "Hide score";
            this.lblToggleScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblToggleScore.Click += new System.EventHandler(this.lblToggleScore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score";
            // 
            // lblNrOfCorrectAnswers
            // 
            this.lblNrOfCorrectAnswers.AutoSize = true;
            this.lblNrOfCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOfCorrectAnswers.Location = new System.Drawing.Point(22, 65);
            this.lblNrOfCorrectAnswers.Name = "lblNrOfCorrectAnswers";
            this.lblNrOfCorrectAnswers.Size = new System.Drawing.Size(178, 36);
            this.lblNrOfCorrectAnswers.TabIndex = 1;
            this.lblNrOfCorrectAnswers.Text = "0 / 0 Correct";
            // 
            // lblCorrectOrWrong
            // 
            this.lblCorrectOrWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectOrWrong.Location = new System.Drawing.Point(27, 303);
            this.lblCorrectOrWrong.Name = "lblCorrectOrWrong";
            this.lblCorrectOrWrong.Size = new System.Drawing.Size(252, 23);
            this.lblCorrectOrWrong.TabIndex = 8;
            this.lblCorrectOrWrong.Text = "[Cleared on init]";
            this.lblCorrectOrWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEndPractice
            // 
            this.btnEndPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndPractice.Location = new System.Drawing.Point(442, 367);
            this.btnEndPractice.Name = "btnEndPractice";
            this.btnEndPractice.Size = new System.Drawing.Size(310, 60);
            this.btnEndPractice.TabIndex = 9;
            this.btnEndPractice.Text = "End practice";
            this.btnEndPractice.UseVisualStyleBackColor = true;
            // 
            // FormPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.btnEndPractice);
            this.Controls.Add(this.lblCorrectOrWrong);
            this.Controls.Add(this.lblToggleScore);
            this.Controls.Add(this.groupBoxScore);
            this.Controls.Add(this.textBoxTranslation);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblWordUsedInSentence);
            this.Controls.Add(this.lblToggleShowSentence);
            this.Controls.Add(this.lblWordToTranslate);
            this.Controls.Add(this.lblDescription);
            this.Name = "FormPractice";
            this.Text = "UpVocabulary - Practice";
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblWordToTranslate;
        private System.Windows.Forms.Label lblToggleShowSentence;
        private System.Windows.Forms.Label lblWordUsedInSentence;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label lblToggleScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNrOfCorrectAnswers;
        private System.Windows.Forms.Label lblCorrectOrWrong;
        private System.Windows.Forms.Button btnEndPractice;
    }
}