using Class09.Domain.Models;

namespace Class09.Infrastructure.Database
{
    public class ChinookRepository
    {
        private readonly chinookContext _context;
        public ChinookRepository(chinookContext context)
        {
            _context = context;
        }

        public List<Customer> GetCustomersByCountry(string country)
        {
            var result = _context.Customers.Where(c => c.Country == country).Select(c =>
                new Customer
                {
                    Country = country,
                    Name = c.FirstName + " " + c.LastName,
                    ClientId = c.CustomerId
                });
            return result.ToList();
        }

        public List<Invoice> GetInvoicesByCountry(string country)
        {
            var result = (from invoices in _context.Invoices
                          join customer in _context.Customers
                          on invoices.CustomerId equals customer.CustomerId
                          where invoices.BillingCountry == country
                          select new Invoice
                          {
                              ClientName = customer.FirstName + " " + customer.LastName,
                              InvoiceId = invoices.InvoiceId,
                              InvoiceDate = invoices.InvoiceDate,
                              Country = invoices.BillingCountry
                          });
            return result.ToList();
        }

        public List<List<Employee>> GroupEmployeesByTitle()
        {
            var result = _context.Employees.Select(e =>
            new Employee
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Title = e.Title
            }).GroupBy(e => e.Title).Select(e => e.ToList());
            return result.ToList();
        }
    }
}
