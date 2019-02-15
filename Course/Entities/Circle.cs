using Course.Entities.Enums;
using System;

namespace Course.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = Radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
