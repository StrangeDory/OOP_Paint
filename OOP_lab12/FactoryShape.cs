using System;
using System.Collections.Generic;
using System.Drawing;
using FigureLibrary;

namespace OOP_lab12
{
    public class FactoryShape
    {
        public Shape GetShape(string shapeName)
        {
            switch (shapeName)
            {
                case "Circle":
                    return new Circle();
                case "Ellipse":
                    return new Ellipse();
                case "Square":
                    return new Square();
                case "Adapter":
                    return new Adapter();
                case "Right_triangle":
                    return new Right_triangle();
                case "Rectangle":
                    return new Rectangle();
                case "Point":
                    return new Point();
                case "Polyline":
                    return new Polyline();
                case "Triangle":
                    return new Triangle();
                default:
                    throw new Exception($"Sorry this shape ({shapeName}) is not yet implemented");
            }
        }
    }
}
