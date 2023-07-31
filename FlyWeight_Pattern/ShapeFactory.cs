using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    public class ShapeFactory
    {
        private Dictionary<string, Shape> shapes = new Dictionary<string, Shape>();

        public Shape GetShape(string type, ConsoleColor color)
        {
            string key = $"{type}_{color}";

            if (!shapes.TryGetValue(key, out Shape shape))
            {
                switch (type.ToLower())
                {
                    case "circle":
                        shape = new Circle(5, color);
                        break;
                    case "square":
                        shape = new Square(10, color);
                        break;

                    default:
                        throw new ArgumentException("Unsupported shape type");
                }

                shapes.Add(key, shape);
            }

            return shape;
        }
    }
}
