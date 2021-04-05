using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PowerBoat : Vehicles
    {
        public override string Move()
        {
            return "Лодка плывет";
        }

        public override string ShapeName()
        {
            return "Лодка";
        }
    }
}
