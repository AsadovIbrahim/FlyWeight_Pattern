using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    public class DrawingApp
    {
        private List<Shape> shapes = new List<Shape>();
        private ShapeFactory shapeFactory = new ShapeFactory();

        public void AddShape(string type, int x, int y, ConsoleColor color)
        {
            Shape shape = shapeFactory.GetShape(type, color);
            shapes.Add(shape);
            shape.Draw(x, y);
        }
    }
}
