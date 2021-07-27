using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HangMan
{
    class GamePlan
    {
        public float staringPoint { get; private set; }
        public GamePlan(string word,  PaintEventArgs e)
        {
            generateGamePlan(word, e);
        }

        void generateGamePlan(string word, PaintEventArgs e)
        {
            float count = word.Length / 2 * 20;
            float placementX1 = 245 - count;
            float placementX2 = 220 - count;
            float y1 = 290;
            float y2 = 290;
            //int x1 = 250;
            //int x2 = 220;
            // Pen blackPen = new Pen(Color.Black, 3);
            // e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);

            staringPoint = placementX2;

            for (int i = 0; i < word.Length; i++)
            {
                float x1 = placementX1;
                float x2 = placementX2;
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
    }
}
