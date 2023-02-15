namespace przychodnia.DAL
{
    public class Specjalizacja
    {
        private String nazwaSpecjalizacji;
        private int rokUzyskania;

        public Specjalizacja(string nazwaSpecjalizacji, int rokUzyskania)
        {
            this.nazwaSpecjalizacji = nazwaSpecjalizacji;
            this.rokUzyskania = rokUzyskania;
        }
        public String specjalizacjaJakoNaps() {
            return $"{nazwaSpecjalizacji} uzyskana w roku {Convert.ToString(rokUzyskania)}";
        }
    }
}