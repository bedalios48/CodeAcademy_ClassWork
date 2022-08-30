namespace Class08.Domain.Models.Class0822
{
    public class Hobby
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string TextLt { get; set; }
        public Hobby()
        {

        }
        public Hobby(int id, string text, string textLt)
        {
            Id = id;
            Text = text;
            TextLt = textLt;
        }

        public void InitializeData(string text)
        {
            var items = text.Split(',');
            if (items.Length < 3)
                return;

            if (!int.TryParse(items[0], out var id))
                return;

            Id = id;
            Text = items[1];
            TextLt = items[2];
        }
    }
}
