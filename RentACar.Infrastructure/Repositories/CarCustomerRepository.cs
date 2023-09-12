using RentACar.Domain.Entities;
using RentACar.Domain.Interfaces;
using RentACar.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Infrastructure.Repositories
{
    public class CarCustomerRepository : ICarCustomerRepository
    {
        private static RentACarDBContext _db;
        public CarCustomerRepository()
        {
            if (_db == null)
            {
                _db = new RentACarDBContext();
            }
        }

        public void Create(CarCustomer carCustomer)
        {
            _db.CarCustomers.Add(carCustomer);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            CarCustomer carCustomer = GetById(id);
            if (carCustomer != null)
            {
                _db.CarCustomers.Remove(carCustomer);
                _db.SaveChanges();
            }
        }

        public List<CarCustomer> GetAll()
        {
            return _db.CarCustomers.ToList();
        }

        public CarCustomer GetById(int id)
        {
            return _db.CarCustomers.FirstOrDefault(c => c.CarCustomerID == id);
        }

        public void Update(CarCustomer carCustomer)
        {
            CarCustomer currentCarCustomer = _db.CarCustomers.FirstOrDefault(c => c.CarCustomerID == carCustomer.CarCustomerID != null);
            if (currentCarCustomer != null)
            {
                _db.Entry(carCustomer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();
            }
        }
    }
}
