using ApiMokymai.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public List<Person> GetMyPersons()
        {
            return new List<Person>
            {
                new Person {Id =  1, Name="Jonas", Surname="Jonaitis"},
                new Person {Id =  2, Name="Petras", Surname="Petraitis"},
                new Person {Id =  3, Name="Urte", Surname="Urtaite"}
            };
        }
    }
}
