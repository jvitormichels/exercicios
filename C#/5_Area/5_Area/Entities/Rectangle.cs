using _5_Area.Entities.Enums;

namespace _5_Area.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return (Height * Width);
        }
    }
}
