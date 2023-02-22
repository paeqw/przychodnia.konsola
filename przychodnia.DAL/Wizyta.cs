using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.DAL
{
    public class Wizyta
    {
        private Lekarz lekarz;
        private DateOnly data;

        public Wizyta(Lekarz lekarz, DateOnly data)
        {
            this.lekarz = lekarz;
            this.data = data;
        }
    }
}
