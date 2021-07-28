
namespace HangMan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.letterBox = new System.Windows.Forms.TextBox();
            this.guessLetter = new System.Windows.Forms.Button();
            this.segaCount = new System.Windows.Forms.Label();
            this.appleCount = new System.Windows.Forms.Label();
            this.microsoftCount = new System.Windows.Forms.Label();
            this.ibmCount = new System.Windows.Forms.Label();
            this.atariCount = new System.Windows.Forms.Label();
            this.nintendoCount = new System.Windows.Forms.Label();
            this.rWord = new System.Windows.Forms.Label();
            this.isIt = new System.Windows.Forms.Label();
            this.won = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // letterBox
            // 
            this.letterBox.Location = new System.Drawing.Point(43, 394);
            this.letterBox.Name = "letterBox";
            this.letterBox.Size = new System.Drawing.Size(70, 23);
            this.letterBox.TabIndex = 0;
            // 
            // guessLetter
            // 
            this.guessLetter.Location = new System.Drawing.Point(104, 394);
            this.guessLetter.Name = "guessLetter";
            this.guessLetter.Size = new System.Drawing.Size(75, 23);
            this.guessLetter.TabIndex = 1;
            this.guessLetter.Text = "Guess!";
            this.guessLetter.UseVisualStyleBackColor = true;
            this.guessLetter.Click += new System.EventHandler(this.guessLetter_Click);
            // 
            // segaCount
            // 
            this.segaCount.AutoSize = true;
            this.segaCount.Location = new System.Drawing.Point(456, 59);
            this.segaCount.Name = "segaCount";
            this.segaCount.Size = new System.Drawing.Size(0, 15);
            this.segaCount.TabIndex = 2;
            // 
            // appleCount
            // 
            this.appleCount.AutoSize = true;
            this.appleCount.Location = new System.Drawing.Point(456, 83);
            this.appleCount.Name = "appleCount";
            this.appleCount.Size = new System.Drawing.Size(0, 15);
            this.appleCount.TabIndex = 3;
            // 
            // microsoftCount
            // 
            this.microsoftCount.AutoSize = true;
            this.microsoftCount.Location = new System.Drawing.Point(456, 113);
            this.microsoftCount.Name = "microsoftCount";
            this.microsoftCount.Size = new System.Drawing.Size(0, 15);
            this.microsoftCount.TabIndex = 4;
            // 
            // ibmCount
            // 
            this.ibmCount.AutoSize = true;
            this.ibmCount.Location = new System.Drawing.Point(456, 142);
            this.ibmCount.Name = "ibmCount";
            this.ibmCount.Size = new System.Drawing.Size(0, 15);
            this.ibmCount.TabIndex = 5;
            // 
            // atariCount
            // 
            this.atariCount.AutoSize = true;
            this.atariCount.Location = new System.Drawing.Point(456, 172);
            this.atariCount.Name = "atariCount";
            this.atariCount.Size = new System.Drawing.Size(0, 15);
            this.atariCount.TabIndex = 6;
            // 
            // nintendoCount
            // 
            this.nintendoCount.AutoSize = true;
            this.nintendoCount.Location = new System.Drawing.Point(456, 200);
            this.nintendoCount.Name = "nintendoCount";
            this.nintendoCount.Size = new System.Drawing.Size(0, 15);
            this.nintendoCount.TabIndex = 7;
            // 
            // rWord
            // 
            this.rWord.AutoSize = true;
            this.rWord.Location = new System.Drawing.Point(43, 36);
            this.rWord.Name = "rWord";
            this.rWord.Size = new System.Drawing.Size(38, 15);
            this.rWord.TabIndex = 8;
            this.rWord.Text = "label1";
            // 
            // isIt
            // 
            this.isIt.AutoSize = true;
            this.isIt.Location = new System.Drawing.Point(118, 36);
            this.isIt.Name = "isIt";
            this.isIt.Size = new System.Drawing.Size(38, 15);
            this.isIt.TabIndex = 9;
            this.isIt.Text = "label1";
            // 
            // won
            // 
            this.won.AutoSize = true;
            this.won.Location = new System.Drawing.Point(292, 45);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(0, 15);
            this.won.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.won);
            this.Controls.Add(this.isIt);
            this.Controls.Add(this.rWord);
            this.Controls.Add(this.nintendoCount);
            this.Controls.Add(this.atariCount);
            this.Controls.Add(this.ibmCount);
            this.Controls.Add(this.microsoftCount);
            this.Controls.Add(this.appleCount);
            this.Controls.Add(this.segaCount);
            this.Controls.Add(this.guessLetter);
            this.Controls.Add(this.letterBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox letterBox;
        private System.Windows.Forms.Button guessLetter;
        private System.Windows.Forms.Label segaCount;
        private System.Windows.Forms.Label appleCount;
        private System.Windows.Forms.Label microsoftCount;
        private System.Windows.Forms.Label ibmCount;
        private System.Windows.Forms.Label atariCount;
        private System.Windows.Forms.Label nintendoCount;
        private System.Windows.Forms.Label rWord;
        private System.Windows.Forms.Label isIt;
        private System.Windows.Forms.Label won;
    }
}

