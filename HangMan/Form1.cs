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
            
            word = new Word();
            rightWord = word.word.ToLower();
            wrongX = 150.0F;
            guesses = new List<string>();

            hangMan = new HangManFigures();
        
           
            this.BackColor = Color.Bisque;
            this.AcceptButton = guessLetter;
        }

        HangManFigures hangMan;
        int rightPlace = 0;
        string rightWord;
        float wrongX;
        List<string> guesses;
        Word word;
        GamePlan gamePlan;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            rWord.Text = rightWord;
            gamePlan = new GamePlan(rightWord ,e);
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
            else if (letterBox.Text.Length > 1 || letterBox.Text.Length <= 0)
            {
                isIt.Text = "One letter or the whole word please!";
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
            won.Text = rightPlace.ToString();
            if (rightPlace == rightWord.Length)
            {
                won.Text = "Bingo! You won :)";
            }

            letterBox.Text = "";

        
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
            //float x = 190.0F;
            float x = 190.0F;
            float y = 260.0F;

            for (int i = 0; i < rightWord.Length; i++)
            {
                if (letterBox.Text == rightWord[i].ToString())
                {
                    rightPlace++;
                    isIt.Text = "Yes its a match!";
                    x = (gamePlan.staringPoint) + (i * 40);
                    myGraphics.DrawString(guess, drawFont, drawBrush, x, y);

                }
            }

        
    
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

        static int coun= 0;

        private void hangButton_Click(object sender, EventArgs e)
        {
            switch (coun)
            {
                case 0:
                    hangMan.Ground(this);
                    break;
                case 1:
                    hangMan.Stump(this);
                    break;
                case 2:
                    hangMan.Pile(this);
                    break;
                case 3:
                    hangMan.Twig(this);
                    break;
                case 4:
                    hangMan.Rope(this);
                    break;
                case 5:
                    hangMan.Head(this);
                    break;
                case 6:
                    hangMan.Body(this);
                    break;
                case 7:
                    hangMan.Arms(this);
                    break;
                case 8:
                    hangMan.LeftLeg(this);
                    break;
                case 9:
                    hangMan.RightLeg(this);
                    break;
               
            }
            coun++;

        }
    }
}
