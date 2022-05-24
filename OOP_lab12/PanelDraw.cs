using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using FigureLibrary;


namespace OOP_lab12
{
    class PanelDraw
    {
        public static void draw(Graphics g, Shape shape)
        {
            if (shape is Ellipse)
                drawEllipse(g, (Ellipse)shape);
            else
                drawFigure(g, shape);
        }

        public static void drawFigure(Graphics g, Shape shape)
        {
            if (shape.masX.Count > 1)
            {
                Pen pen = new Pen(shape.getBorderColor(), 2);
                for (int i = 0; i < shape.masX.Count - 1; i++)
                    g.DrawLine(pen, shape.masX[i], shape.masY[i], shape.masX[i + 1], shape.masY[i + 1]);
                g.DrawLine(pen, shape.masX[0], shape.masY[0], shape.masX[shape.masX.Count - 1], shape.masY[shape.masY.Count - 1]);
            }
            else
            {
                SolidBrush aBrush = new SolidBrush(shape.getBorderColor());
                g.FillRectangle(aBrush, shape.masX[0], shape.masY[0], 2, 2);
            }
        }

        public static void drawEllipse(Graphics g, Ellipse shape)
        {
            Pen pen = new Pen(shape.getBorderColor(), 2);
            System.Drawing.RectangleF rect = new System.Drawing.RectangleF(shape.masX[0], shape.masY[0], shape.masX[1] - shape.masX[0], shape.masY[1] - shape.masY[0]);
            g.DrawEllipse(pen, rect);
        }
    }
}
