namespace Class08.Models.Class0804
{
    internal class Dziovykla
    {
        public int Aukstis { get; set; }
        public int Ilgis { get; set; }
        public int Plotis { get; set; }
        public string Medziaga { get; set; }
        public List<Drabuzis> KabantysDrabuziai { get; set; } = new List<Drabuzis>();
    }
}
