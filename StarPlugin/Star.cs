using System;
using System.Drawing;
using AFigure;

namespace Star_Plugin
{
    [Serializable]
    public class Star : Figure
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private static string name = "Звезда";

        public static string ClassName
        {
            get { return name; }
        }

        override public string Name
        {
            get { return name; }
        }

        public override int BorderWidth { get; set; }

        public override Color FigureColor { get; set; }

        override public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        override public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        override public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        override public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public Point[] GetPoints()
        {
            int startX = Math.Min(x1, x2);
            int startY = Math.Min(y1, y2);
            int endX = Math.Max(x1, x2);
            int endY = Math.Max(y1, y2);
            Point[] points = {
                new Point((endX - startX) / 2 + startX, startY),
                new Point((endX - startX) * 35 / 100 + startX, (endY - startY) * 35 / 100 + startY),
                new Point(startX, (endY - startY) / 2 + startY),
                new Point((endX - startX) * 35 / 100 + startX, endY - (endY - startY) * 35 / 100),
                new Point((endX - startX) / 2 + startX, endY),
                new Point(endX - (endX - startX) * 35 / 100, endY - (endY - startY) * 35 / 100),
                new Point(endX, (endY - startY) / 2 + startY),
                new Point(endX - (endX - startX) * 35 / 100, (endY - startY) * 35 / 100 + startY)
            };
            return points;
        }
        override public void Draw(Graphics g)
        {
            Point[] points = GetPoints();
            g.DrawPolygon(new Pen(FigureColor, BorderWidth), points);
        }
        public override Figure Clone()
        {
            return new Star()
            {
                X1 = this.X1,
                Y1 = this.Y1,
                X2 = this.X2,
                Y2 = this.Y2,
                BorderWidth = this.BorderWidth,
                FigureColor = this.FigureColor
            };
        }
    }
}

