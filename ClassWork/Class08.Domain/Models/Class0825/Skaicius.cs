using Class08.Domain.Interfaces.Class0825;

namespace Class08.Domain.Models.Class0825
{
    public class Skaicius : IMatematika
    {
        private readonly int _skaicius;

        public Skaicius(int skaicius)
        {
            _skaicius = skaicius;
        }

        public int Atimti(int skaicius) => _skaicius - skaicius;

        public double Padalinti(int skaicius) => _skaicius / (double)skaicius;

        public int Padauginti(int skaicius) => _skaicius * skaicius;

        public int PakeltiKubu() => _skaicius * _skaicius * _skaicius;

        public int PakeltiKvadratu() => _skaicius * _skaicius;

        public int Prideti(int skaicius) => _skaicius + skaicius;
    }
}
