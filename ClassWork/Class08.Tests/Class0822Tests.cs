using Class08.Domain.Models.Class0822;

namespace Class08.Tests
{
    [TestClass]
    public class Class0822Tests
    {
        [TestMethod]
        public void InitializeData_InitializesProperties()
        {
            var fake = "1,Astrology,Astrologija";
            var hobby = new Hobby();
            hobby.InitializeData(fake);
            var expected = new Hobby(1, "Astrology", "Astrologija");

            Assert.AreEqual(expected.Id, hobby.Id);
            Assert.AreEqual(expected.Text, hobby.Text);
            Assert.AreEqual(expected.TextLt, hobby.TextLt);
        }
    }
}