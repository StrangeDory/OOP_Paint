using System;
using System.Drawing;

namespace AFigure
{
    [Serializable]
    abstract public class Figure
    {
        abstract public int X1 { get; set; }
        abstract public int Y1 { get; set; }
        abstract public int X2 { get; set; }
        abstract public int Y2 { get; set; }
        abstract public string Name { get; }
        abstract public int BorderWidth { get; set; }
        abstract public Color FigureColor { get; set; }
        abstract public void Draw(Graphics g);
        abstract public Figure Clone();
    }
}
