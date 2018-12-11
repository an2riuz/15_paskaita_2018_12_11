using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_paskaita_2018_12_11
{
    enum Kalendorius {Sausis = 1, Vasaris, Kovas, Balandis, Geguze, Birzelis, Liepa, Rugpjutis, Rugsejis, Spalis, Lapkritis, Gruodis }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Klase klase = new Klase();
            Struktura struktura = new Struktura();

            klase.Print();
            struktura.Print();

            EnumKlase belekas = new EnumKlase();

            belekas.koksLaikmetis(Kalendorius.Birzelis);

            Console.ReadKey();
            */
            int[] masyvas = new int[3];

            try
            {
                
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[4] = test;

            } catch (FormatException)
            {
                Console.WriteLine("Klaida!");
                Console.ReadKey();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Skaicius uz ribos!");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Daug erroru!");
            }
            finally
            {
                Console.WriteLine("Laba diena!");
                Console.ReadKey();
            }

            public class MyCustomException : Exception
        {
            public MyCustomException(string errorMsg) : base
        }
        }
    }
}
