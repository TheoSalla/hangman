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
            rightWord = word.word;
     

            this.BackColor = Color.Bisque;
        }

        string rightWord;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rWord.Text = rightWord;
            
            GamePlan gamePlan = new GamePlan(rightWord ,e);

           

        }

        private void guessLetter_Click(object sender, EventArgs e)
        {
           
        
        }

      
   
    }
}
