using System;
namespace ConsoleApp1
{
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
 }
