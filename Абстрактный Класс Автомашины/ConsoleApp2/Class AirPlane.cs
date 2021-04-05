using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class AirPlane : Vehicles
    {
        public override string Move()
        {
            return "Самолет летит";
        }

        public override string ShapeName()
        {
            return "Самолет";
        }
    }
}
