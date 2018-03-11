using System;
using System.Collections.Generic;

namespace AbstractCalss
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            foreach (var shape in shapes)
                Console.WriteLine(shape.GetShape());
        }
    }
}
