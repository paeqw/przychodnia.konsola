using przychodnia.DAL;
Specjalizacja s1 = new Specjalizacja("Rodzinny", 1999);
Specjalizacja s2 = new Specjalizacja("Ginekolog", 2002);
Lekarz lekarz1 = new Lekarz("Adam", "Kowalski", new List<Specjalizacja> { s1, s2 });
Lekarz lekarz2 = new Lekarz("Joanna", "Kowalska", new List<Specjalizacja> { s1, s2 });
/*OperacjeNaPlikach.zapiszLekarzaDoPliku("C:\\Users\\Paeqw\\Desktop\\txt.txt",lekarz1);
OperacjeNaPlikach.zapiszLekarzaDoPliku("C:\\Users\\Paeqw\\Desktop\\txt.txt",lekarz2);*/
var wszyscy = OperacjeNaPlikach.czytajLekarzyZPliku("C:\\Users\\Paeqw\\Desktop\\txt.txt");
foreach(var el in wszyscy)
{
    Console.WriteLine(el.lekarzJakoNapis() + " \n");
}


