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
    public class CarParkRepository : ICarParkRepository
    {
        private static RentACarDBContext _db;
        public CarParkRepository()
        {
            if (_db == null)
            {
                _db = new RentACarDBContext();
            }
        }

        public void Create(CarPark carPark)
        {
            _db.CarParks.Add(carPark);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            CarPark carPark = GetById(id);
            if (carPark != null)
            {
                _db.CarParks.Remove(carPark);
                _db.SaveChanges();
            }
        }

        public List<CarPark> GetAll()
        {
            return _db.CarParks.ToList();
        }

        public CarPark GetById(int id)
        {
            return _db.CarParks.FirstOrDefault(c => c.CarParkID == id);
        }

        public void Update(CarPark carPark)
        {
            CarPark currentCarPark = _db.CarParks.FirstOrDefault(c => c.CarParkID == carPark.CarParkID != null);
            if (currentCarPark != null)
            {
                _db.Entry(carPark).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();
            }
        }
    }
}
