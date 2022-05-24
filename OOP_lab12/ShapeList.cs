using System.Drawing;
using System.Collections.Generic;
using System;
using FigureLibrary;

namespace OOP_lab12
{
    [Serializable]
    class ShapeList
    {
        public List<Shape> shapeList;

        public ShapeList()
        {
            this.shapeList = new List<Shape>();
        }

        public Shape getLast()
        {
            return shapeList[Count() - 1];
        }

        public int Count()
        {
            return shapeList.Count;
        }

        public void add(Shape shape)
        {
            shapeList.Add(shape);
        }

        public void removeLast()
        {
            shapeList.RemoveAt(shapeList.Count-1);
        }

        public void removeAll()
        {
            shapeList.Clear();
        }

        public void draw(Graphics g)
        {
            foreach(Shape shape in shapeList)
            {
                PanelDraw.draw(g, shape);
            }
        }
    }
}
