using System;
namespace ConsoleApp1
{
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
}
