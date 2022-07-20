using Class07.ClassWork;

namespace Class07.Tests
{
    [TestClass]
    public class Class0720Tests
    {
        [TestMethod]
        public void IstrauktiSkaiciusIsTeksto_GrazinaSkaiciuSarasa()
        {
            var fake = "fdsf78fdaf54fa6+9vds22";
            var expected = "78546922";
            var result = Class0720.IstrauktiSkaiciusIsTeksto(fake);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SurikiuotiSkaicius_GrazinaDidejanciuSkaiciuSarasa()
        {
            var fake = "78546922";
            var expected = new List<int> { 2, 2, 4, 5, 6, 7, 8, 9 };
            var result = Class0720.SurikiuotiSkaicius(fake);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}