using Class08.Enums.Class0816;

namespace Class08.Models.Class0816
{
    internal class Society
    {
        /*Sukurkite klasę Society
         1- Sukurkite propertį People (List of persons)
         2- sukurkite metodą FillPeople kuris užpildys sąrašą iš klasės PersonInitialData.
         3- Sukurkite propertį OldPeople. Grąžinkite visus asmenis kurie gimė prieš 2001m. (unit-test)
         4- Sukurkite properčius Men ir Women.
         5- Sukurkite metodus FillMen ir FillWomen, kurie iš PersonInitialData surašys vyrus ir moteris (unit-test)
         6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašus esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio.
         7- Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenis  rikiuos nuo A iki Z arba nuo Z iki A.
            Pagal Vardą arba Pavardę
              tokiu principu: SortByFirstName().Asc()
                              SortByLastName().Asc()
                              SortByLastName().Desc()
            <hint> return this*/
        public List<Person> People { get; set; } = new List<Person>();
        public List<Person> Men { get; set; } = new List<Person>();
        public List<Person> Women { get; set; } = new List<Person>();

        public void FillPeople()
        {
            People.AddRange(PersonInitialData.DataSeed);
        }
        public void FillMen()
        {
            foreach(var person in PersonInitialData.DataSeed)
                if(person.Gender == EGenderType.MALE)
                    Men.Add(person);
        }
        public void FillWomen()
        {
            foreach (var person in PersonInitialData.DataSeed)
                if (person.Gender == EGenderType.FEMALE)
                    Women.Add(person);
        }

        public void SortByAge()
        {
            var people = Men.ToArray();
            SortByAge(people);
            Men = people.ToList();

            people = Women.ToArray();
            SortByAge(people);
            Women = people.ToList();
        }

        private void SortByAge(Person[] people)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i].BirthDate < people[j].BirthDate)
                    {
                        var person = people[i];
                        people[i] = people[j];
                        people[j] = person;
                    }
                }
            }
        }

        public List<Person> OldPeople { get 
            {
                var date = new DateTime(2001, 1, 1);
                var oldPeople = new List<Person>();
                foreach (var person in People)
                    if(person.BirthDate < date)
                        oldPeople.Add(person);
                return oldPeople;
            } 
        }
    }
}
