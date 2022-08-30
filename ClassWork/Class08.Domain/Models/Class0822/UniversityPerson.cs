namespace Class08.Domain.Models.Class0822
{
    public class UniversityPerson : Person
    {
        public virtual Profession Profession { get; set; }
        public List<Hobby> Hobbies { get; set; }

        public void AssignHobbies(string[] data)
        {
            var hobbies = data.ToList();
            var random = new Random();
            var noOfHobbies = random.Next(0, 5);
            for(int i = 1; i <= noOfHobbies; i++)
            {
                var index = random.Next(hobbies.Count);

            }
        }

        public void SetProfession(Profession[] data)
        {

        }

        public string GetCsv()
        {
            var data = new List<string>();
            data.Add(Profession.Id.ToString());
            data.Add(FirstName);
            data.Add(LastName);
            return "";
        }
    }
}
