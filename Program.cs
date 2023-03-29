
using EquatableTask;
using System;
using System.Linq;

namespace EquatableTask
{
    class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new Pracownik();
            Console.WriteLine(p1);

            p1.Nazwisko = "Wrona";
            p1.Wynagrodzenie = 200;
            p1.DataZatrudnienia = new DateTime(2022, 10, 09);
            Console.WriteLine(p1);

            var p2 = new Pracownik(new DateTime(2022, 09, 01), "Kaszan", 150);
            Console.WriteLine(p2);


        }

    }
}