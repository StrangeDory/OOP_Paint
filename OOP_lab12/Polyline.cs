using System.Drawing;
using System.Collections.Generic;
using System;
using FigureLibrary;


namespace OOP_lab12
{
    [Serializable]
    class Polyline : Shape
    {
        //public List<Point> points = new List<Point>();

        public Polyline() { }

        public Polyline(List<float> a, List<float> b)
        {
            for(int i = 0; i < a.Count; i++)
                addPoint(a[i], b[i]);
        }

        public Polyline(Point point)
        {
            addPoint(point.x, point.y);
        }

        public Polyline(List<Point> Points)
        {
            foreach(var point in Points)
                addPoint(point.x, point.y);
        }

        public void addPoint(Point p)
        {
            addPoint(p.x, p.y);
        }

        public void addPoint(int x, int y)
        {
            addPoint(x, y);
        }

        public override void MouseMove(float topX, float topY, float bottomX, float bottomY)
        {
            masX = new List<float> { topX, bottomX };
            masY = new List<float> { topY, bottomY };
        }

        public override Shape Clone()
        {
            return new Polyline(masX, masY);
        }
    }
}
