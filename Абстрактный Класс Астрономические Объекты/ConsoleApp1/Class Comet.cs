using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Comet : AstronomicalObjects
    {
        public override string Move()
        {
            return "Комета Летит";
        }

        public override string Size()
        {
            return "Среднее";
        }

        public override string ShapeName()
        {
            return "Комета";
        }
    }
}
