using System;
using System.Collections.Generic;
using System.Text;
using FigureLibrary;


namespace RombPlugin
{
    [Serializable]
    public class Romb : Shape
    {
        public Romb() { }

        public Romb(float topX, float topY, float bottomxX, float bottomY) : base(new List<float> { topX, topX + (bottomxX - topX) / 2, bottomxX, bottomxX - (bottomxX - topX) / 2 }, new List<float> { topY + (bottomY - topY) / 2, topY, topY + (bottomY - topY) / 2, bottomY })
        { }

        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        {

            masX = new List<float> { topX, topX + (bottomX - topX) / 2, bottomX, bottomX - (bottomX - topX) / 2 };
            masY = new List<float> { topY + (bottomY - topY) / 2, topY, topY + (bottomY - topY) / 2, bottomY };
        }

        public override Shape Clone()
        {
            return new Romb();
        }
    }
}
