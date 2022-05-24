using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OOP_lab12
{
    [Serializable]
    class Right_triangle : Polyline
    {
        public Right_triangle() { }
        public Right_triangle(Point point, Point Bottom) : base(new List<Point>() { point, Bottom, new Point(point.x, Bottom.y) }) { }
        public Right_triangle(List<float> a, List<float> b) : base(a, b) { }
        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        {
            masX = new List<float> { topX, bottomX, topX };
            masY = new List<float> { topY, bottomY, bottomY };
        }

        public override Shape Clone()
        {
            return new Right_triangle(masX, masY);
        }
    }
}
