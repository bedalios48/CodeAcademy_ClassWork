using Class0620.ClassWork;

namespace Class0620.Tests
{
    [TestClass]
    public class Class0628Tests
    {
        [TestMethod]
        public void ArVeikia_PanaikintiTarpusKrastuose()
        {
            var fake = "    testas testas      ";
            var expected = "testas testas";
            Class0628.PanaikintiTarpusKrastuose(ref fake);
            var result = fake;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ArVeikia_SkaiciuotiTarpus()
        {
            var fake = "    testas       testas   ";
            var expected = 2;
            var result = Class0628.SkaiciuotiZodzius(fake);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ArVeikia_GrazintiTarpuKiekiTekstoGale()
        {
            var fake = "testas       ";
            var expected = 7;
            var result = Class0628.GrazintiTarpuKiekiTekstoGale(fake);
            Assert.AreEqual(expected , result);
        }

        [TestMethod]
        public void ArVeikia_GrazintiTarpuKiekiTekstoPradzioje()
        {
            var fake = "     testas";
            var expected = 5;
            var result = Class0628.GrazintiTarpuKiekiTekstoPradzioje(fake);
            Assert.AreEqual(expected , result);
        }

        [TestMethod]
        public void ArVeikia_GrazintiTarpusGale_TarpaiGale()
        {
            var fake = "     testas testas  ";
            var expected = 2;
            var result = Class0628.GrazintiTarpusGale(fake, out _);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ArVeikia_GrazintiTarpusGale_TarpaiPriekyje()
        {
            var fake = "     testas testas  ";
            var expected = 5;
            Class0628.GrazintiTarpusGale(fake, out var result);
            Assert.AreEqual(expected, result);
        }
    }
}