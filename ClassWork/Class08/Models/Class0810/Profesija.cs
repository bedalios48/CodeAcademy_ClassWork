namespace Class08.Models.Class0810
{
    internal class Profesija
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private string tekstasLietuviskai;

        public string TekstasLietuviskai
        {
            get { return tekstasLietuviskai; }
            private set { tekstasLietuviskai = value; }
        }
        
        private string tekstas;

        public string Tekstas
        {
            get { return tekstas; }
            private set { tekstas = value; }
        }

        public Profesija()
        {

        }

        public Profesija(int id, string tekstasLietuviskai, string tekstas)
        {
            Id = id;
            TekstasLietuviskai = tekstasLietuviskai;
            Tekstas = tekstas;
        }
    }
}
