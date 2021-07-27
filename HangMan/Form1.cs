using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 600;
            this.Height = 600;
            Word word = new Word();
            rightWord = word.word.ToLower();
            wrongX = 150.0F;
            guesses = new List<string>();
     

            this.BackColor = Color.Bisque;
        }

        string rightWord;
        float wrongX;
        List<string> guesses;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rWord.Text = rightWord;
            GamePlan gamePlan = new GamePlan(rightWord ,e);

           

        }

        private void guessLetter_Click(object sender, EventArgs e)
        {
            if (guesses.Contains(letterBox.Text.ToLower()))
            {
                isIt.Text = "You already guessed that!";

            }
            else if (letterBox.Text == rightWord)
            {
                isIt.Text = "You got it!";
            }
            else if (letterBox.Text.Length > 1)
            {
                isIt.Text = "Only one letter or the whole world please!";
            }
            else
            {
                if (rightWord.ToLower().Contains(letterBox.Text.ToLower()))
                {
                    guesses.Add(letterBox.Text.ToLower());
                    isIt.Text = "Yes!";
                    rightLetter();

                }
                else
                {
                    guesses.Add(letterBox.Text.ToLower());
                    isIt.Text = "Nope!";
                    wrongLetter();
                }
            }


        
        }

        private void rightLetter()
        {
            Graphics myGraphics = CreateGraphics();

            // Create string to draw.
            String guess = letterBox.Text;

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            float x = 190.0F;
            float y = 260.0F;
            myGraphics.DrawString(guess, drawFont, drawBrush, x, y);
    
        }
        private void wrongLetter()
        {
            Graphics myGraphics = CreateGraphics();

            string guess = letterBox.Text;

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            float x = wrongX;
            float y = 320.0F;
            myGraphics.DrawString(guess, drawFont, drawBrush, x, y);
            wrongX += 15;

        }

      
   
    }
}
