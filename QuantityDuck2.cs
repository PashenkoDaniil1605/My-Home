using System;
namespace ConsoleApp1
{
class QuantityDuck2 : QuantityDuckBase
    {

        public QuantityDuck2(ADuck[] arr)
        {

            _ducks = arr.ToList();
            _index = 0;

        }

    }
}
