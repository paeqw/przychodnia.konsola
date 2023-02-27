using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.DAL
{
    public class Lekarz
    {
        private String imie;
        private String nazwisko;
        List<Specjalizacja> specjalizacje;

        public Lekarz(string imie, string nazwisko, List<Specjalizacja> specjalizacje)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.specjalizacje = specjalizacje;
        }
        public String lekarzJakoNapis()
        {
            String specjalizacjeString = $"Lekarz {imie} {nazwisko} uzyskal specjaizacje : ";
            foreach(var el in specjalizacje)
            {
                specjalizacjeString += el.specjalizacjaJakoNaps();
            }
            return specjalizacjeString + " \n";
        }
    }
}
