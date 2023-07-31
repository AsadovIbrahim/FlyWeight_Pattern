using System;
using System.Collections.Generic;
namespace FlyWeight_Pattern
{

    

   
   
    
    

    class Program
    {
        static void Main()
        {
            DrawingApp drawingApp = new DrawingApp();

            drawingApp.AddShape("circle", 10, 20, ConsoleColor.Red);
            drawingApp.AddShape("square", 30, 40, ConsoleColor.Green);
            drawingApp.AddShape("circle", 50, 60, ConsoleColor.Blue);
            drawingApp.AddShape("square", 70, 80, ConsoleColor.Yellow);
        }
    }

}