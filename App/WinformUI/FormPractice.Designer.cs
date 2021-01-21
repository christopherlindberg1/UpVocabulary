
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblWordToTranslate = new System.Windows.Forms.Label();
            this.lblToggleSentence = new System.Windows.Forms.Label();
            this.lblWordUsedInSentence = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.lblNrOfCorrectAnswers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToggleScore = new System.Windows.Forms.Label();
            this.lblCorrectOrWrong = new System.Windows.Forms.Label();
            this.btnEndPractice = new System.Windows.Forms.Button();
            this.btnSubmitTranslation = new System.Windows.Forms.Button();
            this.lblCorrectTranslation = new System.Windows.Forms.Label();
            this.btnGetNextWord = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnPracticeAgain = new System.Windows.Forms.Button();
            this.groupBoxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(27, 27);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(295, 29);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Words from list - set on init";
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
            // lblToggleSentence
            // 
            this.lblToggleSentence.AutoSize = true;
            this.lblToggleSentence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblToggleSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleSentence.Location = new System.Drawing.Point(32, 117);
            this.lblToggleSentence.Name = "lblToggleSentence";
            this.lblToggleSentence.Size = new System.Drawing.Size(247, 20);
            this.lblToggleSentence.TabIndex = 2;
            this.lblToggleSentence.Text = "Show [word] used in a sentence";
            this.lblToggleSentence.Click += new System.EventHandler(this.lblToggleShowSentence_Click);
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
            this.textBoxTranslation.Size = new System.Drawing.Size(315, 27);
            this.textBoxTranslation.TabIndex = 5;
            this.textBoxTranslation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTranslation_KeyPress);
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.lblNrOfCorrectAnswers);
            this.groupBoxScore.Controls.Add(this.label1);
            this.groupBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxScore.Location = new System.Drawing.Point(592, 65);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(310, 126);
            this.groupBoxScore.TabIndex = 6;
            this.groupBoxScore.TabStop = false;
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
            // lblToggleScore
            // 
            this.lblToggleScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblToggleScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleScore.Location = new System.Drawing.Point(770, 33);
            this.lblToggleScore.Name = "lblToggleScore";
            this.lblToggleScore.Size = new System.Drawing.Size(132, 23);
            this.lblToggleScore.TabIndex = 7;
            this.lblToggleScore.Text = "Hide score";
            this.lblToggleScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblToggleScore.Click += new System.EventHandler(this.lblToggleScore_Click);
            // 
            // lblCorrectOrWrong
            // 
            this.lblCorrectOrWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectOrWrong.ForeColor = System.Drawing.Color.White;
            this.lblCorrectOrWrong.Location = new System.Drawing.Point(32, 359);
            this.lblCorrectOrWrong.Name = "lblCorrectOrWrong";
            this.lblCorrectOrWrong.Padding = new System.Windows.Forms.Padding(10);
            this.lblCorrectOrWrong.Size = new System.Drawing.Size(315, 70);
            this.lblCorrectOrWrong.TabIndex = 8;
            this.lblCorrectOrWrong.Text = "[Cleared on init]";
            this.lblCorrectOrWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEndPractice
            // 
            this.btnEndPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndPractice.Location = new System.Drawing.Point(592, 563);
            this.btnEndPractice.Name = "btnEndPractice";
            this.btnEndPractice.Size = new System.Drawing.Size(310, 60);
            this.btnEndPractice.TabIndex = 9;
            this.btnEndPractice.Text = "End practice";
            this.btnEndPractice.UseVisualStyleBackColor = true;
            this.btnEndPractice.Click += new System.EventHandler(this.btnEndPractice_Click);
            // 
            // btnSubmitTranslation
            // 
            this.btnSubmitTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitTranslation.Location = new System.Drawing.Point(32, 293);
            this.btnSubmitTranslation.Name = "btnSubmitTranslation";
            this.btnSubmitTranslation.Size = new System.Drawing.Size(315, 38);
            this.btnSubmitTranslation.TabIndex = 10;
            this.btnSubmitTranslation.Text = "Submit";
            this.btnSubmitTranslation.UseVisualStyleBackColor = true;
            this.btnSubmitTranslation.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblCorrectTranslation
            // 
            this.lblCorrectTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectTranslation.Location = new System.Drawing.Point(32, 476);
            this.lblCorrectTranslation.Name = "lblCorrectTranslation";
            this.lblCorrectTranslation.Size = new System.Drawing.Size(315, 58);
            this.lblCorrectTranslation.TabIndex = 11;
            this.lblCorrectTranslation.Text = "The correct translation is [correct translation]";
            // 
            // btnGetNextWord
            // 
            this.btnGetNextWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetNextWord.Location = new System.Drawing.Point(394, 476);
            this.btnGetNextWord.Name = "btnGetNextWord";
            this.btnGetNextWord.Size = new System.Drawing.Size(125, 40);
            this.btnGetNextWord.TabIndex = 12;
            this.btnGetNextWord.Text = "Next word";
            this.btnGetNextWord.UseVisualStyleBackColor = true;
            this.btnGetNextWord.Click += new System.EventHandler(this.btnGetNextWord_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 20;
            this.listBoxResults.Location = new System.Drawing.Point(592, 229);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(310, 304);
            this.listBoxResults.TabIndex = 13;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(588, 206);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(66, 20);
            this.lblResults.TabIndex = 14;
            this.lblResults.Text = "Results";
            // 
            // btnPracticeAgain
            // 
            this.btnPracticeAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPracticeAgain.Location = new System.Drawing.Point(32, 563);
            this.btnPracticeAgain.Name = "btnPracticeAgain";
            this.btnPracticeAgain.Size = new System.Drawing.Size(487, 60);
            this.btnPracticeAgain.TabIndex = 15;
            this.btnPracticeAgain.Text = "Practice again";
            this.btnPracticeAgain.UseVisualStyleBackColor = true;
            this.btnPracticeAgain.Click += new System.EventHandler(this.btnPracticeAgain_Click);
            // 
            // FormPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 653);
            this.Controls.Add(this.btnPracticeAgain);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.btnGetNextWord);
            this.Controls.Add(this.lblCorrectTranslation);
            this.Controls.Add(this.btnSubmitTranslation);
            this.Controls.Add(this.btnEndPractice);
            this.Controls.Add(this.lblCorrectOrWrong);
            this.Controls.Add(this.lblToggleScore);
            this.Controls.Add(this.groupBoxScore);
            this.Controls.Add(this.textBoxTranslation);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblWordUsedInSentence);
            this.Controls.Add(this.lblToggleSentence);
            this.Controls.Add(this.lblWordToTranslate);
            this.Controls.Add(this.lblHeading);
            this.Name = "FormPractice";
            this.Text = "UpVocabulary - Practice";
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblWordToTranslate;
        private System.Windows.Forms.Label lblToggleSentence;
        private System.Windows.Forms.Label lblWordUsedInSentence;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.Label lblToggleScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNrOfCorrectAnswers;
        private System.Windows.Forms.Label lblCorrectOrWrong;
        private System.Windows.Forms.Button btnEndPractice;
        private System.Windows.Forms.Button btnSubmitTranslation;
        private System.Windows.Forms.Label lblCorrectTranslation;
        private System.Windows.Forms.Button btnGetNextWord;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnPracticeAgain;
    }
}