using System;


namespace Лаборатоная.Classes
{
    class Point : Figure
    {
        public Point(string color, bool visible) : base(color, visible) { }

        public override void Show()
        {
            Console.WriteLine($"Точка: Цвет = {Color}, Координаты = ({X}, {Y}), Видимость = {Visible}");
        }
    }
}
