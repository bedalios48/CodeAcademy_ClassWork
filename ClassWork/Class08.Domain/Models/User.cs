using Class08.Domain.Enums;

namespace Class08.Domain.Models
{
    public class User
    {
        public User()
        {

        }
        public User(string[] data)
        {
            if (data.Length > 0)
                Id = Convert.ToInt32(data[0]);
            if (data.Length > 1)
                FirstName = data[1];
            if (data.Length > 2)
                LastName = data[2];
            if (data.Length > 3)
                Email = data[3];
            if (data.Length > 4)
                Gender = (EGender)Enum.Parse(typeof(EGender), data[4]);
            if (data.Length > 5)
                Salary = Convert.ToDouble(data[5]);
            if (data.Length > 6)
                FavoriteColor = data[6];
            if (data.Length > 7)
                BirthDate = DateTime.Parse(data[7]);
        }

        //id,first_name,last_name,email,gender,salary,favorite_color,birth_date

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EGender Gender { get; set; }
        public double Salary { get; set; }
        public string FavoriteColor { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
