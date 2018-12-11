using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_paskaita_2018_12_11
{
    class EnumKlase
    {
        private Kalendorius menesiai;

        public EnumKlase()
        {

        }

        public void koksLaikmetis(Kalendorius men) {
            switch (men)
            {
                case Kalendorius.Sausis:
                    Console.WriteLine("Menuo yra Sausis");
                    break;

                case Kalendorius.Vasaris:
                    Console.WriteLine("Menuo yra Vasaris");
                    break;

                case Kalendorius.Kovas:
                    Console.WriteLine("Menuo yra Vasaris");
                    break;

                case Kalendorius.Balandis:
                    Console.WriteLine("Menuo yra Vasaris");
                    break;

                case Kalendorius.Geguze:
                    Console.WriteLine("Menuo yra Vasaris");
                    break;

                case Kalendorius.Birzelis:
                    Console.WriteLine("Menuo yra Vasaris");
                    break;
            }
        }
    }
}
