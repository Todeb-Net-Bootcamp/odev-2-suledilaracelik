using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2.Abstract
{
    public abstract class Araba
    {
        //base classta özelliklerimi oluşturdum.
        public string renk = "siyah";
        public string yakit_turu = "benzin";
        public string vites_turu = "otomatik";
        private string model_yili = "1999";
        public abstract void motor_gucu_hesapla();

        public virtual void parksensörü()
        {
            Console.WriteLine("Park sensörü vardır.");
        }

        public string ad
        {
            get
            {
                return model_yili;
            }
            set
            {
                model_yili = value;
            }
        }

    }
}
