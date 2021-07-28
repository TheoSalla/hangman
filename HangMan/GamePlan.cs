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
            float count;
            float placementX1;
            float placementX2;

            if(word.Length % 2 == 1)
            {
                count = word.Length / 2 * 40;
                placementX1 = 283 - count;
                placementX2 = 313 - count;
            }
            else
            {
                count = word.Length / 2 * 40;
                placementX1 = 305 - count;
                placementX2 = 335 - count;
            }


            float y1 = 360;
            float y2 = 360;

            staringPoint = placementX2 - 25;

            for (int i = 0; i < word.Length; i++)
            {
                float x1 = placementX1;
                float x2 = placementX2;
                Pen blackPen = new Pen(Color.Black, 3);
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
