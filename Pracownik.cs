using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquatableTask
{
    public class Pracownik : IEquatable<Pracownik>
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

        public int CzasZatrudnienia => (DateTime.Now - DataZatrudnienia).Days / 30;


        public override string ToString() => $"({Nazwisko}, {DataZatrudnienia:dd MM yyyy} ({CzasZatrudnienia}), {Wynagrodzenie} PLN)";


        public Pracownik(DateTime dataZatrudnienia = default, string nazwisko = "Anonim", decimal wynagrodzenie = 0)
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


    }
}
