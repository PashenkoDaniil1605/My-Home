using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fish : Animal
    {
        public override string Type()
        {
            return "Безпозвоночное";
        }

        public override string Class()
        {
            return "Молюск";
        }

        public override string ShapeName()
        {
            return "Рыба";
        }
    }
}
