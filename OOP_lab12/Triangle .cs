using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OOP_lab12
{
    [Serializable]
    class Triangle : Polyline
    {
        public Triangle() { }
        public Triangle(Point point, Point Bottom) : base(new List<Point>() {point, Bottom, new Point(2 * point.x - Bottom.x, Bottom.y) }) { }
        public Triangle(List<float> a, List<float> b) : base(a, b) { }
        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        {
            masX = new List<float> { topX, bottomX, 2 * topX - bottomX };
            masY = new List<float> { topY, bottomY, bottomY };
        }

        public override Shape Clone()
        {
            return new Triangle(masX, masY);
        }
    }
}
