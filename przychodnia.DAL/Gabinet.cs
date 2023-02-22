using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.DAL
{
    public class Gabinet
    {
        private int numer_gabinetu;
        private Lekarz lekarz;

        public Gabinet(int numer_gabinetu, Lekarz lekarz)
        {
            this.numer_gabinetu = numer_gabinetu;
            this.lekarz = lekarz;
        }
    }
}
