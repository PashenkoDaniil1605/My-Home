using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Acircle : Figure
    {
        double diametr, radius;


        public Acircle(double squareDiametr, double squareRadius)
        {
            diametr = squareDiametr;
            radius = squareRadius;
        }


        public double Diametr
        {
            get { return diametr; }
            set { diametr = value < 0 ? -value : value; }
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value < 0 ? -value : value; }
        }


        public override string Area()
        {
            return (Math.Pow(radius, 2) * Math.PI).ToString();
        }


        public override string Perimeter()
        {
            return (diametr * Math.PI).ToString();
        }


        public override string ShapeName()
        {
            return "Круг";
        }
    }
}
