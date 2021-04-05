using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Star : AstronomicalObjects
    {
        public override string Move()
        {
            return "Звезда стот на месте";
        }

        public override string Size()
        {
            return "Маленькая";
        }

        public override string ShapeName()
        {
            return "Звезда";
        }
    }
}
