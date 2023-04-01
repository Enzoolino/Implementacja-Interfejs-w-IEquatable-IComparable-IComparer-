
namespace EquatableTask
{
    public class WgCzasuZatrudnieniaPotemWgWynagrodzeniaComparer : IComparer<Pracownik>
    {
        public int Compare (Pracownik x, Pracownik y)
        {
            if (x is null && y is null) return 0;
            if (x is null) return -1;
            if (y is null) return 1;
            

            if(x.CzasZatrudnienia != y.CzasZatrudnienia)
                return (x.CzasZatrudnienia.CompareTo (y.CzasZatrudnienia));

            return x.Wynagrodzenie.CompareTo(y.Wynagrodzenie);
               
        }
    }
}
