using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_paskaita_2018_12_11
{
    class Klase : IPrintData
    {
        public void Print()
        {
            Console.WriteLine(pavarde);
            Console.WriteLine(metai);
            Console.WriteLine(saraselis);
        }
        public string pavarde = "Valeris";
        public int metai = 34;

        public List<int> saraselis = new List<int> {12, 34, 65 };

        public Klase()
        {

        }
    }
}
