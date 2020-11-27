﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ICluck
    {
        void Cluck();
    }
    class TurkeyCockCluck : ICluck
    {
        public void Cluck()
        {
            Console.WriteLine("Я умею кудахтать!");
        }
    }
    interface IFly
    {
        void Fly();
    }
    class DucksFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Я умею летать!");
        }
    }
    class DucksDontFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Я не умею летать!");
        }
    }
    class DucksFastFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Я летаю на реативной тяге!");
        }
    }
    interface IQuack
    {
        void Quack();
    }
    class DucksQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Я умею крякать!");
        }
    }
    class DucksDontQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Я не умею крякать!");
        }
    }
    class DucksPisckQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Я издаю писки!");
        }
    }
    interface ISwimm
    {
        void Swimm();
    }

    class DucksSwimm : ISwimm
    {
        public void Swimm()
        {
            Console.WriteLine("Я умею плавать!");
        }
    }
    class DucksDontSwimm : ISwimm
    {
        public void Swimm()
        {
            Console.WriteLine("Я не умею плавать!");
        }
    }
    class DucksWalkSwimm : ISwimm
    {
        public void Swimm()
        {
            Console.WriteLine("Я плаваю на поверхности!");
        }
    }
    interface IGo
    {
        void Go();
    }
    class DucksGo : IGo
    {
        public void Go()
        {
            Console.WriteLine("Я умею ходить!");
        }
    }
    class DucksDontGo : IGo
    {
        public void Go()
        {
            Console.WriteLine("Я не умею ходить!");
        }
    }
    class DucksStopGo : IGo
    {
        public void Go()
        {
            Console.WriteLine("Я стою на месте!");
        }
    }
    class ADuck
    {
        private IFly _fly;
        public virtual void fDuckMet()
        {
            _fly.Fly();
        }
        public ADuck(IFly f)
        {
            _fly = f;
        }
        private IQuack _quack;
        public virtual void qDuckMet()
        {
            _quack.Quack();
        }
        public ADuck(IQuack q)
        {
            _quack = q;
        }
        private ISwimm _swimm;
        public virtual void sDuckMet()
        {
            _swimm.Swimm();
        }
        public ADuck(ISwimm s)
        {
            _swimm = s;
        }
        private IGo _go;
        public virtual void gDuckMet()
        {
            _go.Go();
        }
        public ADuck(IGo g)
        {
            _go = g;
        }
        public ADuck(IFly f, IQuack q, ISwimm s, IGo g)
        {
            _fly = f;
            _quack = q;
            _swimm = s;
            _go = g;
        }
        public virtual void ShowGolos()
        {
            fDuckMet();
            qDuckMet();
            sDuckMet();
            gDuckMet();
        }
        public ADuck()
        {
            _fly = new DucksFly();
            _quack = new DucksQuack();
            _swimm = new DucksSwimm();
            _go = new DucksGo();
        }
    }
    class ATurkeyCock
    {
        private IFly _fly;
        public ATurkeyCock(IFly f)
        {
            _fly = f;
        }

        public virtual void fDuckMet()
        {
            _fly.Fly();
        }

        private ICluck _cluck;
        public ATurkeyCock(ICluck c)
        {
            _cluck = c;
        }
        public virtual void cDuckMet()
        {
            _cluck.Cluck();
        }

        private ISwimm _swimm;
        public ATurkeyCock(ISwimm s)
        {
            _swimm = s;
        }
        public virtual void sDuckMet()
        {
            _swimm.Swimm();
        }
        private IGo _go;
        public ATurkeyCock(IGo g)
        {
            _go = g;
        }
        public virtual void gDuckMet()
        {
            _go.Go();
        }
        public ATurkeyCock(IFly f, ICluck c, ISwimm s, IGo g)
        {
            _fly = f;
            _cluck = c;
            _swimm = s;
            _go = g;
        }
        public virtual void ShowGolos()
        {
            fDuckMet();
            cDuckMet();
            sDuckMet();
            gDuckMet();
        }
    }
    class Duck : ADuck
    {
        public Duck() : base(new DucksFly(), new DucksQuack(), new DucksSwimm(), new DucksGo())
        {

        }
        public override void ShowGolos()
        {
            Console.WriteLine("___________________");
            Console.WriteLine("Это Обычная Утка - ");
            Console.WriteLine("___________________");
            base.ShowGolos();
        }

    }
    class WoodDuck : ADuck
    {
        public WoodDuck() : base(new DucksDontFly(), new DucksDontQuack(), new DucksWalkSwimm(), new DucksStopGo())
        {

        }
        public override void ShowGolos()
        {
            Console.WriteLine("______________________");
            Console.WriteLine("Это Деревянная Утка - ");
            Console.WriteLine("______________________");
            base.ShowGolos();
        }
    }
    class RuberDuck : ADuck
    {
        public RuberDuck() : base(new DucksDontFly(), new DucksPisckQuack(), new DucksWalkSwimm(), new DucksStopGo())
        {

        }
        public override void ShowGolos()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine("Это Резиновая Утка - ");
            Console.WriteLine("_____________________");
            base.ShowGolos();
        }
    }
    class TurkeyCock : ATurkeyCock
    {
        public TurkeyCock() : base(new DucksDontFly(), new TurkeyCockCluck(), new DucksWalkSwimm(), new DucksStopGo())
        {

        }
        public override void ShowGolos()
        {
            Console.WriteLine("____________________");
            Console.WriteLine("Это Обычный Индюк - ");
            Console.WriteLine("____________________");
            base.ShowGolos();
        }
    }
    class AdapterTurkeyCock : ADuck
    {
        private TurkeyCock _turkeycock;
        public AdapterTurkeyCock(TurkeyCock turkeyCock)
        {
            _turkeycock = turkeyCock;
        }
        public override void fDuckMet()
        {
            base.fDuckMet();
        }
        public override void qDuckMet()
        {
            Console.WriteLine("Я умею крякать!");
        }
        public override void sDuckMet()
        {
            base.sDuckMet();
        }
        public override void gDuckMet()
        {
            base.gDuckMet();
        }

        public override void ShowGolos()
        {
            Console.WriteLine("_________________________");
            Console.WriteLine("Индюк скрутился в утку - ");
            Console.WriteLine("_________________________");
            base.ShowGolos();
        }
    }
    class DucksShop<T>
    {
        private ICollection<T> Menu;
    }



    interface IBossEnumerator<T> : IEnumerable<T>
    {

        T Current(int j);
        void NextLevel();

    }

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
    class QuantityDuck : QuantityDuckBase
    {

        public QuantityDuck(List<ADuck> list)
        {
            _ducks = list;
        }

    }
    class QuantityDuck2 : QuantityDuckBase
    {

        public QuantityDuck2(ADuck[] arr)
        {

            _ducks = arr.ToList();
            _index = 0;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Duck ducks = new Duck();
            ducks.ShowGolos();
            WoodDuck woodduck = new WoodDuck();
            woodduck.ShowGolos();
            RuberDuck ruberduck = new RuberDuck();
            ruberduck.ShowGolos();
            TurkeyCock turkeyCock = new TurkeyCock();
            turkeyCock.ShowGolos();
            ADuck biduck = new AdapterTurkeyCock(turkeyCock);
            biduck.ShowGolos();
            Console.WriteLine("___________________");
            Console.WriteLine("Меню Уток (Массив):");
            Console.WriteLine("___________________");
            ADuck[] arr = { woodduck, ruberduck, biduck };
            QuantityDuck2 duckarray = new QuantityDuck2(arr);
            duckarray.OutPutDucks();
            Console.WriteLine("_________________");
            Console.WriteLine("Меню Уток (Лист):");
            Console.WriteLine("_________________");
            List<ADuck> list = new List<ADuck>();
            list.Add(woodduck);
            list.Add(ruberduck);
            list.Add(biduck);
            QuantityDuck duckList = new QuantityDuck(list);
            duckList.OutPutDucks();
            Console.ReadLine();
        }
    }
}

