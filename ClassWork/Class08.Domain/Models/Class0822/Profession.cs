namespace Class08.Domain.Models.Class0822
{
    public class Profession
    {
        public Profession()
        {
        }

        public Profession(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public string TextLt { get; set; }
    }
}
