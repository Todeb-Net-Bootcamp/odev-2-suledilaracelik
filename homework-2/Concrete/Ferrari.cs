using homework_2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2.Concrete
{
    class Ferrari : Araba
    {
        //araba sınıfından kalıtım aldım.
        public override void motor_gucu_hesapla()
        {
            Console.WriteLine("500");
        }

        public override void parksensörü()
        {
            Console.WriteLine("park sensörü yoktur.");
        }


    }
}
