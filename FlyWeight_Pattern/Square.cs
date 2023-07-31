using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    public class Square:Shape
    {
        private int sideLength;
        private ConsoleColor color;

        public Square(int sideLength, ConsoleColor color)
        {
            this.sideLength = sideLength;
            this.color = color;
        }

        public void Draw(int x, int y)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Drawing a square with side length {sideLength} at position ({x}, {y})");
            Console.ResetColor();
        }
    }
}
