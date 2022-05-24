using System;
using System.Collections.Generic;
using System.Drawing;

namespace FigureLibrary
{
    [Serializable]
    abstract public class Shape
    {
        private Color borderColor;
        public List<float> masX = new List<float>();
        public List<float> masY = new List<float>();

        public Shape()
        {
            borderColor = Color.FromName("Black");
        }

        public Shape(List<float> x, List<float> y)
        {
            this.masX = x;
            this.masY = y;
        }

        public void addPoint(float x, float y)
        {
            addX(x);
            addY(y);
        }

        public void addX(float x)
        {
            masX.Add(x);
        }

        public void addY(float y)
        {
            masY.Add(y);
        }

        public Color getBorderColor()
        {
            return borderColor;
        }

        public void setBorderColor(Color borderColor)
        {
            this.borderColor = borderColor;
        }

        public void offset(float dx, float dy)
        {
            for (int i = 0; i < masX.Count; i++)
            {
                masX[i] += dx;
                masY[i] += dy;
            }
        }

        public abstract void MouseMove(float topX, float topY, float bottomX, float bottomY);

        abstract public Shape Clone();
    }
}
