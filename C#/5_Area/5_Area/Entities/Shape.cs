using System;
using System.Collections.Generic;
using System.Text;
using _5_Area.Entities.Enums;

namespace _5_Area.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
