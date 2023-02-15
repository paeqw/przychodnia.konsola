using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.DAL
{
    internal class Lekarz
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
            return specjalizacjeString;
        }
        public void zapiszLekarzaDoPliku(string path)
        {
            File.AppendAllText(path, this.lekarzJakoNapis());
        }
        public static List<Lekarz> czytajLekarzyZPliku(string path)
        {
            List<Lekarz> lekarze = new List<Lekarz>();
            List<Specjalizacja> specjalizacje = new List<Specjalizacja>();

            var napisy = File.ReadAllLines(path);
            foreach(var el in napisy)
            {
                if (string.IsNullOrEmpty(el)) break;
                var wiersz = el.Split();
                var imie = wiersz[0];
                var nazwisko = wiersz[1];
                for(int i = 3; i< wiersz.Length; i+=5) { 
                    var nazwa = wiersz[i];
                    var rok = Convert.ToInt32(
                        wiersz[i + 5]);

                    Specjalizacja s = new(nazwa, rok);
                    specjalizacje.Add(s);
                }
                lekarze.Add(new Lekarz(imie, nazwisko, specjalizacje));
            }
            return lekarze;
        }
    }
}
