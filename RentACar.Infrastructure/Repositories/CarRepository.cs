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
    public class CarRepository : ICarRepository
    {
        private static RentACarDBContext _db;
        public CarRepository()
        {
            if (_db == null)
            {
                _db = new RentACarDBContext();
            }
        }

        public void Create(Car car)
        {
            _db.Cars.Add(car);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Car car = _db.Cars.FirstOrDefault(c => c.CarID == id);
            if (car != null)
            {
                _db.Cars.Remove(car);
                _db.SaveChanges();
            }
        }

        public List<Car> GetAll()
        {
            return _db.Cars.ToList();
        }

        public Car GetById(int id)
        {
            return _db.Cars.FirstOrDefault(c => c.CarID == id);
        }

        public void Update(Car car)
        {
            Car currentCar = _db.Cars.FirstOrDefault(c => c.CarID == car.CarID != null);
            if (currentCar != null)
            {
                _db.Entry(car).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();
            }
        }
    }
}
