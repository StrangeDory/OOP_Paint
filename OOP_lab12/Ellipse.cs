using System;
using System.Collections.Generic;
using System.Drawing;
using FigureLibrary;

namespace OOP_lab12
{
    [Serializable]
    class Ellipse : Shape
    {

        public Ellipse() { }

        public Ellipse(List<float> x, List<float> y) : base(x, y) { }

        public Ellipse(Point topLeft, Point bottom) : base(new List<float> { topLeft.x, bottom.x}, new List<float> { topLeft.y, bottom.y})
        {
        }

        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        {
            masX = new List<float> { topX, bottomX };
            masY = new List<float> { topY, bottomY };
        }

        public override Shape Clone()
        {
            return new Ellipse(masX, masY);
        }
    }
}
