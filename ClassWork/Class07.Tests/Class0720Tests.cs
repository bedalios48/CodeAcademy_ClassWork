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

        [TestMethod]
        public void IsskaidytiSakini_GrazinaZodziuSarasa()
        {
            var fake = "Labas as esu Kodelskis ir labai megstu programuoti";
            var expected = new List<string> { "Labas", "as", "esu", "Kodelskis", "ir", "labai", "megstu", "programuoti" };
            var result = Class0720.IsskaidytiSakini(fake);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AtskirtiIlgesniusZodzius_PasalinaIlgesniusZodzius()
        {
            var fake = new List<string> { "Labas", "as", "esu", "Kodelskis", "ir", "labai", "megstu", "programuoti" };
            var expected = new List<string> { "as", "esu", "ir" };
            Class0720.AtskirtiIlgesniusZodzius(fake, 5);
            CollectionAssert.AreEqual(expected, fake);
        }

        [TestMethod]
        public void AtskirtiIlgesniusZodzius_GrazinaIlgesniuZodziuSarasa()
        {
            var fake = new List<string> { "Labas", "as", "esu", "Kodelskis", "ir", "labai", "megstu", "programuoti" };
            var expected = new List<string> { "Labas", "Kodelskis", "labai", "megstu", "programuoti" };
            var result = Class0720.AtskirtiIlgesniusZodzius(fake, 5);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SurikiuotiZodzius_GrazinaSurikiuotaSarasa()
        {
            var fake = new List<string> { "Labas", "as", "esu", "Kodelskis", "ir", "labai", "megstu", "programuoti" };
            var expected = new List<string> { "as", "esu", "ir", "Kodelskis", "labai", "Labas", "megstu", "programuoti" };
            Class0720.SurikiuotiZodzius(fake);
            CollectionAssert.AreEqual(expected, fake);
        }

        [TestMethod]
        public void SujungtiDuSarasus_GrazinaSujungtaSarasa()
        {
            var fake1 = new List<string> { "Labas", "as", "esu", "Kodelskis", "ir"};
            var fake2 = new List<string> { "labai", "megstu", "programuoti" };
            var expected = new List<string> { "Labas", "as", "esu", "Kodelskis", "ir", "labai", "megstu", "programuoti" };
            var result = Class0720.SujungtiDuSarasus(fake1, fake2);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsmetytiZodzius_GrazinaSurikiuotusIlgusZodzius()
        {
            var fake = "Labas as esu Kodelskis ir labai megstu programuoti";
            var expected = new List<string> { "Kodelskis", "labai", "Labas", "megstu", "programuoti" };
            var result = Class0720.IsmetytiZodzius(fake, 5, out _);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsmetytiZodzius_IsmetaTrumpusZodzius()
        {
            var fake = "Labas as esu Kodelskis ir labai megstu programuoti";
            var expected = new List<string> { "as", "esu", "ir" };
            Class0720.IsmetytiZodzius(fake, 5, out var result);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}