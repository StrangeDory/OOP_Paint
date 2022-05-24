using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP_lab12
{
    class DraggedFragment
    {
        public System.Drawing.Rectangle SourceRect;//прямоугольник фрагмента в исходном изображении
        public System.Drawing.Point Location;//положение сдвинутого фрагмента

        //прямоугольник сдвинутого фрагмента
        public System.Drawing.Rectangle Rect
        {
            get { return new System.Drawing.Rectangle(Location, SourceRect.Size); }
        }

        //фиксация изменений в исх изображении
        public void Fix(Graphics gr, int width, int height)
        {
            //рисуем вырезанное белое место
            gr.SetClip(SourceRect);
            gr.Clear(Color.White);

            //рисуем сдвинутый фрагмент
            gr.SetClip(Rect);
            gr.DrawImage(new Bitmap(width, height, gr), Location.X - SourceRect.X, Location.Y - SourceRect.Y);
            gr.ResetClip();
        }
    }
}
