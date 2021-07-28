
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
            this.won = new System.Windows.Forms.Label();
            this.wrongBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // letterBox
            // 
            this.letterBox.Location = new System.Drawing.Point(268, 403);
            this.letterBox.Name = "letterBox";
            this.letterBox.Size = new System.Drawing.Size(70, 23);
            this.letterBox.TabIndex = 0;
            // 
            // guessLetter
            // 
            this.guessLetter.Location = new System.Drawing.Point(268, 432);
            this.guessLetter.Name = "guessLetter";
            this.guessLetter.Size = new System.Drawing.Size(70, 23);
            this.guessLetter.TabIndex = 1;
            this.guessLetter.Text = "Guess!";
            this.guessLetter.UseVisualStyleBackColor = true;
            this.guessLetter.Click += new System.EventHandler(this.guessLetter_Click);
            // 
            // won
            // 
            this.won.Location = new System.Drawing.Point(0, 0);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(100, 23);
            this.won.TabIndex = 0;
            // 
            // wrongBar
            // 
            this.wrongBar.Location = new System.Drawing.Point(26, 30);
            this.wrongBar.Name = "wrongBar";
            this.wrongBar.Size = new System.Drawing.Size(141, 23);
            this.wrongBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.wrongBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.wrongBar);
            this.Controls.Add(this.won);
            this.Controls.Add(this.guessLetter);
            this.Controls.Add(this.letterBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hang Man!";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox letterBox;
        private System.Windows.Forms.Button guessLetter;

        private System.Windows.Forms.Label won;
        private System.Windows.Forms.ProgressBar wrongBar;
    }
}

