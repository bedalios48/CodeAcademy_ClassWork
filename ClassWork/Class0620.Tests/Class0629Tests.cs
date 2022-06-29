using Class0620.ClassWork;

namespace Class0620.Tests
{
    [TestClass]
    public class Class0629Tests
    {
        [TestMethod]
        [DataRow("    testas mokausi      ", true)]
        [DataRow("    testas testas      ", false)]
        public void ArVeikia_ArYraZodisMokausi(string fake, bool expected)
        {
            var result = Class0629.ArYraTekstasMokausi(fake);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ArVeikia_GrazintiPirmosARaidesVieta()
        {
            var fake = "ikbddsjajkda";
            var expected = 7;
            var result = Class0629.GrazintiPirmosARaidesVieta(fake);
            Assert.AreEqual(expected, result);
        }
    }
}