using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_paskaita_2018_12_11
{
    struct Struktura : IPrintData
    {
        public void Print()
        {
            Console.WriteLine(vardas);
            Console.WriteLine(amzius);
            Console.WriteLine(sarasas);
        }
        public string vardas;
        public int amzius;

        public List<int> sarasas;

        
        public Struktura(string vardas, int amzius, List<int> sarasas)
        {
            this.vardas = vardas;
            this.amzius = amzius;
            this.sarasas = sarasas;
        }
        

    }
}
