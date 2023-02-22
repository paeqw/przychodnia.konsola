using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.DAL
{
    public class Pacjent
    {
        private string imie;
        private string nazwisko;
        private int pesel;
        private DateOnly data;
        private List<Wizyta> umowione_wizyty;

        public Pacjent(string imie, string nazwisko, int pesel, DateOnly data, List<Wizyta> umowione_wizyty)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.data = data;
            this.umowione_wizyty = umowione_wizyty;
        }
    }
}
