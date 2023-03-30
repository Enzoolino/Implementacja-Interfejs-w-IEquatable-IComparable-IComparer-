using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


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
            /*
            var pracownicy = new List<Pracownik>()
            {
                new Pracownik("Kielesza", new DateTime(2023, 01, 10), 300),
                new Pracownik("Kielesza", new DateTime(2022, 10, 09), 400),
                new Pracownik("Malinowski", new DateTime(2022, 10, 09), 500),
                new Pracownik("Szablina", new DateTime(2022, 08, 23), 500),
                new Pracownik("Lubczan", new DateTime(2023, 02, 27), 150),
                
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
            */

            //KROK 3
            Krok3();

            
            
            
        }
        
        static void Krok3()
        {
            var pracownicy = new List<Pracownik>()
            {
                new Pracownik("Kielesza", new DateTime(2023, 01, 10), 300),
                new Pracownik("Kielesza", new DateTime(2022, 10, 09), 400),
                new Pracownik("Malinowski", new DateTime(2022, 10, 09), 500),
                new Pracownik("Szablina", new DateTime(2022, 08, 23), 500),
                new Pracownik("Lubczan", new DateTime(2023, 02, 27), 150),

            };

            Console.WriteLine("--- Zewnętrzny porządek - obiekt typu IComparer" + Environment.NewLine
                        + "najpierw według czasu zatrudnienia (w miesiącach), " + Environment.NewLine
                        + "a później według wynagrodzenia - wszystko rosnąco");

            pracownicy.Sort(new WgCzasuZatrudnieniaPotemWgWynagrodzeniaComparer());

            foreach (Pracownik p in pracownicy)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine("--- Zewnętrzny porządek - delegat typu Comparison" + Environment.NewLine
                        + "najpierw według czasu zatrudnienia (w miesiącach), " + Environment.NewLine
                        + "a później kolejno według nazwiska i wynagrodzenia - wszystko rosnąco");

            pracownicy.Sort((x, y) => (x.CzasZatrudnienia.ToString("D3")
                + x.Nazwisko + x.Wynagrodzenie.ToString("00000.00")
            ).CompareTo
                (y.CzasZatrudnienia.ToString("D3")
                + y.Nazwisko + y.Wynagrodzenie.ToString("00000.00")
            )
          );

            foreach(Pracownik p in pracownicy)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine("--- Zewnętrzny porządek - delegat typu Comparison" + Environment.NewLine
                       + "kolejno: malejąco według wynagrodzenia, " + Environment.NewLine
                       + "później rosnąca według czasu zatrudnienia");

            pracownicy.Sort((x, y) => (x.Wynagrodzenie != y.Wynagrodzenie) ?
                  (-1) * (x.Wynagrodzenie.CompareTo(y.Wynagrodzenie)) :
                  x.CzasZatrudnienia.CompareTo(y.CzasZatrudnienia)
          );

            foreach(Pracownik p in pracownicy)
            {
                Console.WriteLine(p);
            }    





        }


    }
}