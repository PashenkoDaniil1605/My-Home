using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Rectangle : Figure
    {
        double width;
        double height;


        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            Width = rectangleWidth;
            Height = rectangleHeight;
        }


        public double Width
        {
            get { return width; }
            set { width = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value < 0 ? -value : value; }
        }


        public override string Area()
        {
            return (width * height).ToString();
        }


        public override string Perimeter()
        {
            return (width * 2 + height * 2).ToString();
        }


        public override string ShapeName()
        {
            return "Прямоугольник";
        }
    }
}
