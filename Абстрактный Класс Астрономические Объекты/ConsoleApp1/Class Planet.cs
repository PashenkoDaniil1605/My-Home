using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Planet : AstronomicalObjects
    {
        public override string Move()
        {
            return "Планета крутиться вокруг своей оси";
        }
        public override string Size()
        {
            return "Большая";
        }

        public override string ShapeName()
        {
            return "Планета";
        }
    }
}
