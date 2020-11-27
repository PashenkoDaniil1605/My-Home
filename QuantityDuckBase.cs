using System;
namespace ConsoleApp1
{
class QuantityDuckBase : IBossEnumerator<ADuck>
    {

        protected List<ADuck> _ducks;
        protected int _index;

        public ADuck Current(int j)
        {
            return _ducks[j];
        }
        public ADuck Current()
        {
            return _ducks[_index];
        }
        public System.Collections.Generic.IEnumerator<ADuck> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void NextLevel()
        {
            _index++;
        }
        public void OutPutDucks()
        {
            Console.WriteLine("________________");
            Console.WriteLine("Наше меню уток :");
            Console.WriteLine("________________");
            foreach (var j in _ducks)
            {
                j.ShowGolos();
            }
        }
        public void OutPutIndex()
        {
            Console.WriteLine("____________");
            Console.WriteLine("Номер Утки :");
            Console.WriteLine("____________");
            _ducks[_index].ShowGolos();
        } 

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
