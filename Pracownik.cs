
namespace EquatableTask
{
    public class Pracownik : IEquatable<Pracownik>, IComparable<Pracownik>
    {
        private string _nazwisko;

        public string Nazwisko
        {
            get => _nazwisko;

            set
            {
                _nazwisko = value.Trim();
            }
        }

        private DateTime _datazatrudnienia;

        public DateTime DataZatrudnienia
        {
            get => _datazatrudnienia;

            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _datazatrudnienia = value;
                }
            }
        }

        private decimal _wynagrodzenie;

        public decimal Wynagrodzenie
        {
            get => _wynagrodzenie;

            set
            {
                if (value < 0)
                {
                    _wynagrodzenie = 0;
                }
                else
                {
                    _wynagrodzenie = value;
                }
            }
        }

        //Konstruktor, definicja CzasuZatrudnienia oraz sposób zapisu w stringu.

        public int CzasZatrudnienia => (DateTime.Now - DataZatrudnienia).Days / 30;


        public override string ToString() => $"({Nazwisko}, {DataZatrudnienia:dd MM yyyy} ({CzasZatrudnienia}), {Wynagrodzenie} PLN)";


        public Pracownik(string nazwisko = "Anonim", DateTime dataZatrudnienia = default, decimal wynagrodzenie = 0)
        {
            _nazwisko = nazwisko;
            _datazatrudnienia = dataZatrudnienia;
            _wynagrodzenie = wynagrodzenie;

        }


        
        #region implementacja IEquatable<Pracownik>

        public bool Equals(Pracownik other)
        {
            if (other is null) return false;
            if (Object.ReferenceEquals(this, other))
                return true;

            return (Nazwisko == other.Nazwisko &&
                    DataZatrudnienia == other.DataZatrudnienia &&
                    Wynagrodzenie == other.Wynagrodzenie);
        }

        public override bool Equals(object obj)
        {
            if (obj is Pracownik)
                return Equals((Pracownik)obj);
            else
                return false;
        }

        public override int GetHashCode() => (Nazwisko, DataZatrudnienia, Wynagrodzenie).GetHashCode();

        public static bool Equals(Pracownik p1, Pracownik p2)
        {
            if (p1 == null && p2 == null) return true;
            if (p1 == null && p2 != null) return false;

            return p1.Equals(p2);
        }

        public static bool operator ==(Pracownik p1, Pracownik p2) => Equals(p1, p2);
        public static bool operator !=(Pracownik p1, Pracownik p2) => !(p1 == p2);


        #endregion implementacja IEquatable<Pracownik>
        

       
        #region implementacja IComparable<Pracownik>

        public int CompareTo(Pracownik other)
        {
            if (other is null) return 1;
            if (this.Equals(other)) return 0;

            if (this.Nazwisko != other.Nazwisko)
                return this.Nazwisko.CompareTo(other.Nazwisko);

            if (this.DataZatrudnienia != other.DataZatrudnienia)
                return this.DataZatrudnienia.CompareTo(other.DataZatrudnienia);

            return this.Wynagrodzenie.CompareTo(other.Wynagrodzenie);
            

        }

        #endregion implementacja IComparable<Pracownik>


    }
}
