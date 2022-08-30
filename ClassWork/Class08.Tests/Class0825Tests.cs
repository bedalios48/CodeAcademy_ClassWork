using Class08.Domain.Interfaces.Class0825;
using Class08.Domain.Models.Class0825;

namespace Class08.Tests
{
    [TestClass]
    public class Class0825Tests
    {
        private IMatematika _skaicius;
        private IPayable _employee;
        private double _salary;
        private string _address;

        [TestInitialize]
        public void OnStart()
        {
            var fakeNumber1 = 5;
            _skaicius = new Skaicius(fakeNumber1);
            var testId = 1;
            var testName = "Test Name";
            var testLastName = "Test Last Name";
            _salary = 100;
            _address = "Test Address";
            _employee = new Employee(testId, testName, testLastName, _salary, _address);
        }

        [TestMethod]
        public void SkaiciusAtimti_AtimaSkaiciu()
        {
            var fakeNumber2 = 6;
            var expected = -1;
            var result = _skaicius.Atimti(fakeNumber2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SkaiciusPadalinti_PadalinaSkaiciu()
        {
            var fakeNumber2 = 2;
            var expected = 2.5;
            var result = _skaicius.Padalinti(fakeNumber2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SkaiciusPadauginti_PadauginaSkaiciu()
        {
            var fakeNumber2 = 2;
            var expected = 10;
            var result = _skaicius.Padauginti(fakeNumber2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SkaiciusPakeltiKubu_PakeliaKubuSkaiciu()
        {
            var expected = 125;
            var result = _skaicius.PakeltiKubu();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SkaiciusPakeltiKvadratu_PakeliaKvadratuSkaiciu()
        {
            var expected = 25;
            var result = _skaicius.PakeltiKvadratu();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SkaiciusPrideti_PridedaSkaiciu()
        {
            var fakeNumber2 = 2;
            var expected = 7;
            var result = _skaicius.Prideti(fakeNumber2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CurrentSalary_ReturnsSalary()
        {
            var expected = _salary;
            var actual = _employee.CurrentSalary();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IncreaseSalary_IncreasesSalary()
        {
            var fake = 5;
            var expected = _salary + fake;
            _employee.IncreaseSalary(fake);
            var actual = _employee.CurrentSalary();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalaryAddress_ReturnsMailingAddress()
        {
            var expected = _address;
            var actual = _employee.SalaryAddress();
            Assert.AreEqual(expected, actual);
        }
    }
}
