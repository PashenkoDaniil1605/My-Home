using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Car : Vehicles
    {
        public override string Move()
        {
            return "Машина едет";
        }

        public override string ShapeName()
        {
            return "Машина";
        }
    }
}
