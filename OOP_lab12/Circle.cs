using System.Drawing;
using System;
using FigureLibrary;

namespace OOP_lab12
{
    [Serializable]
    class Circle : Ellipse 
    {
        public Circle() { }
        public Circle(Point top, float side) : base(top,  new Point(top.x + side, top.y + side)) { }

        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        {
            masX = new System.Collections.Generic.List<float> { topX, topX+(bottomX-topX)/2 };
            masY = new System.Collections.Generic.List<float> { topY, topY+ (bottomX - topX) / 2 };
        }

        public override Shape Clone()
        {
            return base.Clone();
        }

    }
}
