using Class07.ClassWork;

namespace Class07.Tests
{
    [TestClass]
    public class Class0721Tests
    {
        [TestMethod]
        public void SukonstruotiKalade_GrazinaSukonstruotaSarasa()
        {
            var fake1 = new List<string> { "1", "2" };
            var fake2 = new List<string> { "3", "4", "5" };
            var expected = new List<string> { "1 3", "1 4", "1 5", "2 3", "2 4", "2 5" };
            var result = Class0721.SukonstruotiKalade(fake1, fake2);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SurikiuotiKalade_SurikiuojaSarasa()
        {
            var fake = new List<string> { "2 3", "2 4", "1 3", "1 4", "1 5", "2 5" };
            var expected = new List<string> { "1 3", "1 4", "1 5", "2 3", "2 4", "2 5" };
            Class0721.SurikiuotiKalade(fake);

            CollectionAssert.AreEqual(expected, fake);
        }
    }
}