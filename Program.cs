
using EquatableTask;
using System;
using System.Linq;

namespace EquatableTask
{
    class Program
    {
        public static void Main(string[] args)
        {

            //TEST DZIAŁALNOŚCI: KROK 1
            /*
            var p1 = new Pracownik();
            Console.WriteLine(p1);

            p1.Nazwisko = "Wrona";
            p1.Wynagrodzenie = 200;
            p1.DataZatrudnienia = new DateTime(2022, 10, 09);
            Console.WriteLine(p1);

            var p2 = new Pracownik("Kaszan", new DateTime(2022, 09, 01), 150);
            Console.WriteLine(p2);
            */

            //KROK 2
            List<Pracownik> pracownicy = new List<Pracownik>()
            {
                new Pracownik("Kielesza", new DateTime(2023, 01, 10), 300),
                new Pracownik("Kielesza", new DateTime(2022, 10, 09), 400),
                new Pracownik("Malinowski", new DateTime(2022, 10, 09), 500),
                new Pracownik("Szablina", new DateTime(2022, 08, 23), 500),
                new Pracownik("Lubczan", new DateTime(2023, 02, 27), 150),
                
                //Drugi Wariant Danych
                /*
                new Pracownik("AAA", new DateTime(2010, 10, 01), 100),
                new Pracownik("AAA", new DateTime(2011, 10, 01), 1000),
                new Pracownik("DDD", new DateTime(2010, 10, 03), 2000),
                new Pracownik("CCC", new DateTime(2010, 10, 02), 1050),
                new Pracownik("BBB", new DateTime(2010, 10, 01), 1050)
                */
            };

            Console.WriteLine("Przed posortowaniem:\n");

            foreach (Pracownik p in pracownicy)
            {
                Console.WriteLine(p);
            }

            pracownicy.Sort();

            Console.WriteLine("Po posortowaniu:\n");

            foreach (Pracownik p in pracownicy)
            {
                Console.WriteLine(p);
            }

 



            

            


        }

    }
}