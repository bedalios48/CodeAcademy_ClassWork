using Class07.ClassWork;

namespace Class07.Tests
{
    [TestClass]
    public class Class0719Tests
    {
        [TestMethod]
        public void RastiDidziausiaSkaiciu_GrazinaDidziausiaSkaiciu()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = 8;
            var result = Class0719.RastiDidziausiaSkaiciu(fake);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PridetiDidziausiaSkaiciuGale_PridedaDidziausiaSkaiciuGale()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9};
            var result = Class0719.PridetiDidziausiaSkaiciuGale(fake);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}