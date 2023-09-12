using RentACar.Domain.Entities;
using RentACar.Domain.Interfaces;
using RentACar.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private static RentACarDBContext _db;
        public CustomerRepository()
        {
            if (_db == null)
            {
                _db = new RentACarDBContext();
            }
        }

        public void Create(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Customer customer = GetById(id);
            if (customer != null)
            {
                _db.Customers.Remove(customer);
                _db.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            return _db.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _db.Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public void Update(Customer customer)
        {
            Customer currentCustomer = _db.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID != null);
            if (currentCustomer != null)
            {
                _db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();
            }
        }
    }
}
