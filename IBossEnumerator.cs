using System;
namespace ConsoleApp1
{
interface IBossEnumerator<T> : IEnumerable<T>
    {

        T Current(int j);
        void NextLevel();

    }
}
