using System;

namespace Лаборатоная.Interfaces
{
    public interface IFigure
    {
        void Move(double deltaX, double deltaY);
        void ChangeColor(string color);
        bool IsVisible();
        void Show();
    }
}
