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
    public class CarParkFloorRepository : ICarParkFloorRepository
    {
        private static RentACarDBContext _db;
        public CarParkFloorRepository()
        {
            if (_db == null)
            {
                _db = new RentACarDBContext();
            }
        }

        public void Create(CarParkFloor carParkFloor)
        {
            _db.CarParkFloors.Add(carParkFloor);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            CarParkFloor carParkFloor = GetById(id);
            if (carParkFloor != null)
            {
                _db.CarParkFloors.Remove(carParkFloor);
                _db.SaveChanges();
            }
        }

        public List<CarParkFloor> GetAll()
        {
            return _db.CarParkFloors.ToList();
        }

        public CarParkFloor GetById(int id)
        {
            return _db.CarParkFloors.FirstOrDefault(c => c.CarParkFloorID == id);
        }

        public void Update(CarParkFloor carParkFloor)
        {
            CarParkFloor currentCarParkFloor = _db.CarParkFloors.FirstOrDefault(c => c.CarParkFloorID == carParkFloor.CarParkFloorID != null);
            if (currentCarParkFloor != null)
            {
                _db.Entry(carParkFloor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();
            }
        }
    }
}
