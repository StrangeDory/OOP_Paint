using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OOP_lab12
{
    [Serializable]
    class Square : Rectangle
    {
        public Square() { }

        public Square(Point top, float Side) : base(top, new Point(top.x+Side, top.y+Side)) { }
        public Square(List<float> a, List<float> b) : base(a, b) { }

        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        {
            masX = new System.Collections.Generic.List<float> { topX, topX + (bottomX - topX) / 2, topX + (bottomX - topX) / 2, topX };
            masY = new System.Collections.Generic.List<float> { topY, topY, topY + (bottomX - topX) / 2, topY + (bottomX - topX) / 2 };
        }

        public override Shape Clone()
        {
            return new Square(masX, masY);
        }
    }
}
