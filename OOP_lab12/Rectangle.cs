using FigureLibrary;
using System;
using System.Collections.Generic;

namespace OOP_lab12
{
    [Serializable]
    class Rectangle : Polyline
    {
        public Rectangle() {  }
        public Rectangle(Point top, Point bottom) : base(new List<Point>() { top, new Point(bottom.x, top.y), bottom, new Point(top.x, bottom.y) }) { }
        public Rectangle(List<float> a, List<float> b) : base(a, b) { }

        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        {
           
            masX = new List<float> { topX, bottomX, bottomX, topX};
            masY = new List<float> { topY, topY, bottomY, bottomY };
        }

        public override Shape Clone()
        {
            return new Rectangle(masX, masY);
        }
    }
}
