using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    public class Circle:Shape
    {
        private int radius;
        private ConsoleColor color;

        public Circle(int radius, ConsoleColor color)
        {
            this.radius = radius;
            this.color = color;
        }

        public void Draw(int x, int y)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Drawing a circle with radius {radius} at position ({x}, {y})");
            Console.ResetColor();
        }
    }
}
