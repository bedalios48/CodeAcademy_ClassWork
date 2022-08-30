using Class08.Enums.Class0816;

namespace Class08.Models.Class0816
{
    public class Person
    {
        /*
          - Id(int), 
          - FirstName(string), 
          - LastName(string), 
          - FullName(readonly string - generuojamas iš FirstName ir LastName)
          - Gender(int - užpildomas tik inicializuojant klasę reikšme arba per metodą iš enumo EGenderType )
          - BirthDate (DateTime - gali būtu null)
          - Height (Decimal)
          - Weight (Decimal)
          - Age (readonly int - gali būti null. Generuojamas iš gimimo datos (BirthDate). Generavimui naudoti metodą) 
          - NameChanges (string - įrašomas tik iš vidaus. Pildomas pakeitus FirstName arba LastName. 
            Saugomi visi pakeitimai csv formatu "senas,naujas" )*/

        public Person()
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public EGenderType Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int? Age => GetAge();
        public string NameChanges { get; private set; }

        private int? GetAge()
        {
            if (BirthDate == null)
                return null;

            var ts = DateTime.Now.Subtract((DateTime)BirthDate);
            return new DateTime(ts.Ticks).Year - 1;
        }

        public void ChangeGender(EGenderType gender)
        {
            Gender = gender;
        }
    }
}
