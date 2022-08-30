using Class08.Domain.Interfaces.Class0825;

namespace Class08.Domain.Models.Class0825
{
    public class Employee : Person, IPayable
    {
        public Employee(int id, string name, string lastName) : base(id, name, lastName)
        {
        }

        public Employee(int id, string name, string lastName, double salary, string address)
            : base(id, name, lastName)
        {
            Salary = salary;
            MailingAddress = address;
        }

        private double Salary { get; set; }
        public string MailingAddress { get; }

        public double CurrentSalary()
        {
            return Salary;
        }

        public void IncreaseSalary(double increment)
        {
            Salary += increment;
        }

        public string SalaryAddress()
        {
            return MailingAddress;
        }
    }
}
