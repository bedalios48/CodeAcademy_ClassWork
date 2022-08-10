namespace Class08.Models.Class0810
{
    internal class Hobis
    {
        private int id;

        public int Id
        {
            get { return id; }
            private set { id = value; }
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
            set { tekstas = value; }
        }

        public Hobis()
        {

        }

        public Hobis(int id, string tekstasLietuviskai, string tekstas)
        {
            Id = id;
            TekstasLietuviskai = tekstasLietuviskai;
            Tekstas = tekstas;
        }
    }
}
