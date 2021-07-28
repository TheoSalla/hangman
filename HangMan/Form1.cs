using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            SetUpGame();
        }
        string alph;
        int wrongGuesses;
        HangManFigures hangMan;
        int rightPlace = 0;
        string rightWord;
        float wrongX;
        List<string> guesses;
        Word word;
        GamePlan gamePlan;
        static int righgtGusses;
        static int coun;
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
            gamePlan = new GamePlan(rightWord ,e);
           
        }




        //Method for the entered Letter
        private void guessLetter_Click(object sender, EventArgs e)
        {

         


            bool isLetter = alph.Contains(letterBox.Text.ToLower());
            //If the letter have been already entered before
            if (guesses.Contains(letterBox.Text.ToLower()))
            {
                MessageBox.Show("You already guessed that!");
                
            }
            //If the right word is entered
           else if (letterBox.Text == rightWord)
            {

                letterBox.Text = rightWord;
                rightLetter();
                MessageBox.Show("You won!");
                PlayAgain();

            }
            else if (letterBox.Text.Length > 1 || letterBox.Text.Length <= 0 || !isLetter)
            {
              
                MessageBox.Show("One letter or the whole word please!");
            }
            else
            {
                if (rightWord.ToLower().Contains(letterBox.Text.ToLower()))
                {
                    guesses.Add(letterBox.Text.ToLower());
                
                    rightLetter();
                    if (righgtGusses == rightWord.Length)
                    {
                        MessageBox.Show("You won!");
                        PlayAgain();
                    }

                }
                else
                {
                    wrongBar.Value += 1;
                    switch (wrongBar.Value)
                    {
                        case 1:
                            wrongBar.ForeColor = Color.Green;
                            break;
                        case 4:
                            wrongBar.ForeColor = Color.Yellow;
                            break;
                        case 8:
                            wrongBar.ForeColor = Color.Red;
                            break;
                    }


                    wrongGuesses++;                   
                    guesses.Add(letterBox.Text.ToLower());
                    wrongLetter();

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
                letterBox.Focus();
            }
            if (wrongGuesses == 10)
            {
                MessageBox.Show("You lost :(");
                PlayAgain();
            }


            letterBox.Text = "";       
        }

        private void SetUpGame()
        {
          
            wrongBar.BackColor = Color.Black;
            wrongBar.Value = 0;
            wrongBar.Maximum = 10;
            wrongBar.Step = 1;
            this.Width = 600;
            this.Height = 600;

            word = new Word();
            rightWord = word.word.ToLower();
            wrongX = 25.0F;
            
            guesses = new List<string>();

            hangMan = new HangManFigures();

            wrongGuesses = 0;
            righgtGusses = 0;
            this.BackColor = Color.Gray;
            this.AcceptButton = guessLetter;
            this.Refresh();
            letterBox.Focus();
            coun = 0;
            alph = "abcdefghijklmnopqrstuvwxyz";
        }

        private void PlayAgain()
        {
            string msg = "You want to play again?";
            string title = "Wanna play?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg, title, buttons);
            if (result == DialogResult.Yes)
            {
                SetUpGame();
            }
            else
            {
              
                this.Close();
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
            float y = 335.0F;
            int count = letterBox.Text.Length -1;
            while (count >= 0)
            {

            for (int i = 0; i < rightWord.Length; i++)
            {
                if (letterBox.Text[count].ToString() == rightWord[i].ToString())
                {
                    righgtGusses++;
                    rightPlace++;

                    x = (gamePlan.staringPoint) + (i * 40);
                    myGraphics.DrawString(guess[count].ToString(), drawFont, drawBrush, x, y);
                   
                    }                 
                }
                count--;
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
            float y = 60.0F;
            myGraphics.DrawString(guess, drawFont, drawBrush, x, y);
            wrongX += 20;

        }
    }
}
