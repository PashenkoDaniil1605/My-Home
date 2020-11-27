using System;
namespace ConsoleApp1
{
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
}
