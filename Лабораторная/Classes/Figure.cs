using System;
using Лаборатоная.Interfaces;

namespace Лаборатоная.Classes
{
    abstract class Figure : IFigure
    {
        protected string Color {get; set;}
        protected bool Visible {get; set;}
        protected double X {get; set;}
        protected double Y {get; set;}

        public Figure(string color, bool visible)
        {
            Color = color;
            Visible = visible;
            X = 0;
            Y = 0;
        }
        public virtual void Move(double deltaX, double deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public void ChangeColor(string color)
        {
            Color = color;
        }

        public bool IsVisible()
        {
            return Visible;
        }

        public void SetVisibility(bool visibility)
        {
            Visible = visibility;
        }
        public abstract void Show();
    }
}
