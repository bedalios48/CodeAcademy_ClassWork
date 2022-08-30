using Class08.Domain.Models;

namespace Class08.ClassWork
{
    internal class Class0818
    {
        public void UserDataFetch()
        {
            int userColumnCount = 8;
            List<User> users = new List<User>();
            string filePath = Environment.CurrentDirectory + "\\InitialData\\UserData1.csv";

            //using (StreamReader sr = new StreamReader(filePath)) { }

            using StreamReader sr = new StreamReader(filePath);

            string userLine;

            sr.ReadLine();

            while ((userLine = sr.ReadLine()) != null)
            {
                string[] userData = userLine.Split(',');

                if (userData.Length != userColumnCount) break;

                User newUser = new User(userData);
                users.Add(newUser);
            }

            foreach (User user in users)
            {
                Console.WriteLine(user.FirstName);
            }
        }
    }
}
