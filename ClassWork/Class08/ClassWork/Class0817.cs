using Class08.Models.Class0816;

namespace Class08.ClassWork
{
    internal class Class0817
    {
        public void SocietyUzdavinys()
        {
            var society = new Society();
            society.FillPeople();
            society.FillMen();
            society.FillWomen();
            society.SortByAge();
            var a = society.Women;
        }
    }
}
