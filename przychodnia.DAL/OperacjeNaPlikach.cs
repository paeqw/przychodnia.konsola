using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.DAL
{
    public class OperacjeNaPlikach
    {
        public static void zapiszLekarzaDoPliku(string path , Lekarz lekarz)
        {
            File.AppendAllText(path, lekarz.lekarzJakoNapis());
        }
        public static List<Lekarz> czytajLekarzyZPliku(string path)
        {
            List<Lekarz> lekarze = new List<Lekarz>();

            var napisy = File.ReadAllLines(path);
            foreach (var el in napisy)
            {
                if (string.IsNullOrEmpty(el)) break;
                var wiersz = el.Split(" ");
                var imie = wiersz[1];
                var nazwisko = wiersz[2];
                List<Specjalizacja> specjalizacje = new List<Specjalizacja>();
                for (int i = 5; i < wiersz.Length-5; i+=5)
                {
                    var nazwa = wiersz[i+1];
                    var rok = Convert.ToInt32(wiersz[i + 5]);

                    Specjalizacja s = new(nazwa, rok);
                    specjalizacje.Add(s);
                }
                lekarze.Add(new Lekarz(imie, nazwisko, specjalizacje));
            }
            return lekarze;
        }
    }
}
