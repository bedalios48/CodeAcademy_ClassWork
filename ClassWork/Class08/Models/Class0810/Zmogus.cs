using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08.Models.Class0810
{
    internal class Zmogus
    {
        public Zmogus() { }

        public Zmogus(string pavarde)
        {
            Pavarde = pavarde;
        }

        public Zmogus(string vardas, string pavarde) : this(pavarde)
        {
            Vardas = vardas;
        }

        public Zmogus(string vardas, string pavarde, Bendrabutis bendrabutis) : this(vardas, pavarde)
        {
            Bendrabutis = bendrabutis;
        }

        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public Bendrabutis Bendrabutis { get; set; }
    }
}
