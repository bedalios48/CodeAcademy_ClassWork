namespace Class08.Models.Class0810
{
    internal class Bendrabutis
    {
        public Bendrabutis()
        {
            Gyventojai = new List<Zmogus>();
        }

        public Bendrabutis(int id, int kambariuSkaicius, decimal kaina) : this()
        {
            BendrabucioId = id;
            KambariuSkaicius = kambariuSkaicius;
            Kaina = kaina;
        }

        public Bendrabutis(List<Zmogus> gyventojai)
        {
            Gyventojai = gyventojai;
        }

        public Bendrabutis(int bendrabucioId, int kambariuSkaicius, decimal kaina, List<Zmogus> gyventojai)
            : this(bendrabucioId, kambariuSkaicius, kaina)
        {
            Gyventojai = gyventojai;
        }

        public void PridetiGyventoja(Zmogus gyventojas)
        {
            Gyventojai.Add(gyventojas);
            gyventojas.Bendrabutis = this;
        }

        public int BendrabucioId { get; set; }
        public int KambariuSkaicius { get; set; }
        public decimal Kaina { get; set; }
        public List<Zmogus> Gyventojai { get; set; }
    }
}
