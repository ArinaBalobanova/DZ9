using System;

namespace Лаборатоная.Classes
{
    class Circle : Point
    {
        public double Radius { get; private set; }

        public Circle(string color, bool visible, double radius) : base(color, visible)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Круг: Радиус = {Radius}, Площадь = {Area()}");
        }
    }
}
