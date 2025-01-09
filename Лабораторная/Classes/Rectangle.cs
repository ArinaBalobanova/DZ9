using System;

namespace Лаборатоная.Classes
{
    class Rectangle : Point
    {
        public double Width {get; private set;}
        public double Height {get; private set;}

        public Rectangle(string color, bool visible, double width, double height) : base(color, visible)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Прямоугольник: Ширина = {Width}, Высота = {Height}, Площадь = {Area()}");
        }
    }
}
