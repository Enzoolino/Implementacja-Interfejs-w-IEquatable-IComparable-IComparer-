using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace EquatableTask
{
    public static class Sortowanie

    {
        public static void SwapElements<T>(this IList<T> list, int i, int j)
        {
            Contract.Requires(list != null);
            Contract.Requires(i >= 0 && i < list.Count);
            Contract.Requires(j >= 0 && j < list.Count);

            if (i == j)
            {
                return;
            }

            T tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;
        }

        public static void Sortuj<T>(this IList<T> lista) where T : IComparable<T>
        {
            int n = lista.Count; //Liczba elementów

            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (lista[i].CompareTo(lista[i + 1]) > 0)
                    {
                        lista.SwapElements(i, i + 1);
                    }
                }
                n--;
            }
            while (n > 1);
        }

        public static void Sortuj<T>(this IList<T> lista, IComparer<T> comparer)
        {
            int n = lista.Count; //Liczba elementów

            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (comparer.Compare(lista[i], lista[i + 1]) > 0)
                    {
                        lista.SwapElements(i, i + 1);
                    }
                }
                n--;
            }
            while (n > 1);
        }

        public static void Sortuj<T>(this IList<T> lista, Comparison<T> comparison)
        {

            int n = lista.Count; //Liczba elementów

            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (comparison(lista[i], lista[i + 1]) > 0)
                    {
                        lista.SwapElements(i, i + 1);
                    }
                }
                n--;
            }
            while (n > 1);

        }
    }

        

       
}
