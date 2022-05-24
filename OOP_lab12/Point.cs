using System.Windows.Forms;
using System.Drawing;
using System;
using FigureLibrary;
using System.Collections.Generic;

namespace OOP_lab12
{
    [Serializable]
    class Point : Shape
    {
        public float x, y;

        public Point() { }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            addX(point.x);
            addY(point.y);
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            addX(x);
            addY(y);
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
            addX(x);
            addY(y);
        }

        public override Shape Clone()
        {
            return new Point(this.x, this.y);
        }

        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        { }

        public static implicit operator System.Drawing.Point(Point v)
        {
            throw new NotImplementedException();
        }
    }
}
