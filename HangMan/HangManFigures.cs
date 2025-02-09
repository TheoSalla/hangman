﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HangMan
{
    class HangManFigures
    {
        public void Head(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            // Create location and size of ellipse.
            //int x = 290;
            int x = 360;
            int y = 90;
            int width = 30;
            int height = 30;

            // Draw ellipse to screen.
            myGraphics.DrawEllipse(blackPen, x, y, width, height);


        }

        public void Body(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            // Create coordinates of points that define line.
            //int x1 = 265;
            int x1 = 375;
            int y1 = 200;
            int x2 = 375;
            //int x2 = 265;
            int y2 = 120;

            // Draw line to screen.
            myGraphics.DrawLine(blackPen, x1, y1, x2, y2);
        }

        public void LeftLeg(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            //int x1 = 290;
            int x1 = 360;
            int y1 = 239;
            //int x2 = 305;
            int x2 = 375;
            int y2 = 199;

            // Draw line to screen.
            myGraphics.DrawLine(blackPen, x1, y1, x2, y2);
        }

        public void RightLeg(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            //int  x1 = 276;
            int x1 = 385;
            int  y1 = 239;
            //int x2 = 266;
            int x2 = 375;
            int y2 = 199;

            // Draw line to screen.
            myGraphics.DrawLine(blackPen, x1, y1, x2, y2);

        }

        public void Arms(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            //int x1 = 245;
            int x1 = 355;
            int y1 = 150;
            //int x2 = 285;
            int x2 = 395;
            int y2 = 150;

            // Draw line to screen.
            myGraphics.DrawLine(blackPen, x1, y1, x2, y2);
        }

        public void Rope(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            // ROPE:
            //int x1 = 265;
            int x1 = 375;
            int y1 = 36;
            //int x2 = 265;
            int x2 = 375;
            int y2 = 89;

            // Draw line to screen.
            myGraphics.DrawLine(blackPen, x1, y1, x2, y2);
        }

        public void Twig(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            //int x1 = 180;
            int x1 = 294;
            int y1 = 37;
            //int x2 = 265;
            int x2 = 374;
            int y2 = 37;

            // Draw line to screen.
            myGraphics.DrawLine(blackPen, x1, y1, x2, y2);
        }

        public void Pile(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            // PILE:
            //int x1 = 180;
            int x1 = 295;
            int y1 = 37;
            //int x2 = 180;
            int x2 = 295;
            int y2 = 240;

            // Draw line to screen.
            myGraphics.DrawLine(blackPen, x1, y1, x2, y2);
        }

        public void Stump(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            //Rectangle rect = new Rectangle(130, 240, 100, 120);
            Rectangle rect = new Rectangle(248, 240, 100, 120);

            // Create start and sweep angles on ellipse.
            float startAngle = 0.0F;
            float sweepAngle = -180.0F;

            // Draw arc to screen.
            myGraphics.DrawArc(blackPen, rect, startAngle, sweepAngle);
        }

        public void Ground(Form1 form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            int x1 = 248;
            int y1 = 300;
    
            int x2 = 348;
            int y2 = 300;

            // Draw line to screen.
            myGraphics.DrawLine(blackPen, x1, y1, x2, y2);

        }

    }
}
