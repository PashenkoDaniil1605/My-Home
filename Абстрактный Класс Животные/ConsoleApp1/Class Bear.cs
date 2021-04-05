using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bear : Animal
    {
        public override string Type()
        {
            return "Позвоночное";
        }

        public override string Class()
        {
            return "Млекопитающее";
        }

        public override string ShapeName()
        {
            return "Медведь";
        }
    }
}
