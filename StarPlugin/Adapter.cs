using System;
using System.Collections.Generic;
using System.Text;
using Star_Plugin;
using FigureLibrary;

namespace OOP_lab12
{
    [Serializable]
    public class Adapter : Shape
    {
        private readonly Star star;

        public Adapter()
        {
            this.star = new Star();
        }

        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        {
            star.X1 = (int)topX;
            star.Y1 = (int)topY;
            star.X2 = (int)bottomX;
            star.Y2 = (int)bottomY;
            System.Drawing.Point[] points = this.star.GetPoints();
            masX.Clear();
            masY.Clear();
            foreach (var point in points) { masX.Add(point.X); masY.Add(point.Y); }
        }

        public override Shape Clone()
        {
            return new Adapter();
        }
    }
}
