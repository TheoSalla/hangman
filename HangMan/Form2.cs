using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HangMan
{
    public partial class theWord : Form
    {
        public theWord()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.Bisque;
            generateWord();
            rightWord.Text = word;
            //this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        public string word { get; set; }
        private void generateWord()
        {
            List<string> words = new List<string>();
            words.Add("Monkey");
            words.Add("Dog");
            words.Add("Elephant");

            Random rnd = new Random();
            int nr = rnd.Next(words.Count);
            word = words[nr];

        }

        private void drawPlan(PaintEventArgs e)
        {
            
            int count = word.Length/2 * 20;
            int placementX1 = 200 - count;
            int placementX2 = 170 -count;
            int y1 = 250;
            int y2 = 250;
            //int x1 = 250;
            //int x2 = 220;
            // Pen blackPen = new Pen(Color.Black, 3);
            // e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);

   
     

            for (int i = 0; i < word.Length; i++)
            {

                int x1 = placementX1;
                int x2 = placementX2;
                Pen blackPen = new Pen(Color.Blue, 3);
                e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
                placementX1 += 30;
                placementX2 += 30;

                Pen space = new Pen(Color.Bisque, 3);
                placementX1 += 10;
                placementX2 += 10;
                x1 = placementX1;
                x2 = placementX2;
                e.Graphics.DrawLine(space, x1, y1, x2, y2);

            }


        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {

            drawPlan(e);


        }
    }
}
