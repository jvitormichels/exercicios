using System;
using System.Globalization;
using System.Collections.Generic;
using _5_Area.Entities;
using _5_Area.Entities.Enums;

namespace _5_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or circle (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (shapeType == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
                else
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                  
                    shapes.Add(new Rectangle(width, height, color));
                }
            }

            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
