using Class09.Domain.Models;
using Newtonsoft.Json;

namespace Class09.ClassWork
{
    public class Class0926
    {
  /* ------------------------------------------------
### Turite sarasa. Serelizuokite json
List<string> games = new List<string> { "Starcraft", "Halo","Legend of Zelda"};
*/

        /* ------------------------------------------------    ### Turite zodyna. Serelizuokite json    
         * Dictionary<string, int> points = new Dictionary<string, int>    {        { "James", 9001 }, 
         * { "Jo", 3474 },        { "Jess", 11926 }    };    */

        /* ------------------------------------------------    ### Sukurkite objekta. skukurkite klase ir
         * serelizuokite json          Account account = new Account          {            
         * Email = "james@example.com",              Active = true,            
         * CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),  
         * Roles = new List<string>         
         * {                  "User",                  "Admin"              }          };          */


        /* ------------------------------------------------     ### sukurkite klase, irasykite json i faila 
         * Movie movie = new Movie{Name = "Bad Boys",Year = 1995 };     */

        public void IJson()
        {
            List<string> games = new List<string> { "Starcraft", "Halo", "Legend of Zelda" };
            var json = JsonConvert.SerializeObject(games, Formatting.Indented);
            Console.WriteLine(json);
        }

        public void DictionaryIJson()
        {
            var points = new Dictionary<string, int> 
            { 
                { "James", 9001 },
                { "Jo", 3474 }, 
                { "Jess", 11926 } 
            };
            var json = JsonConvert.SerializeObject(points, Formatting.Indented);
            Console.WriteLine(json);
        }

        public void AccountIJson()
        {
            var account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string> { "User", "Admin" }
            };
            var json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);
        }

        public void MovieIJson()
        {
            var movie = new Movie { Name = "Bad Boys", Year = 1995 };
            var json = JsonConvert.SerializeObject(movie, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
