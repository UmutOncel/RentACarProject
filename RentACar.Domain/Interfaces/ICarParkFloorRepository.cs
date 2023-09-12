using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Interfaces
{
    public interface ICarParkFloorRepository:IBaseRepository
    {
        void Create(CarParkFloor carParkFloor);
        void Update(CarParkFloor carParkFloor);
        CarParkFloor GetById(int id);
        List<CarParkFloor> GetAll();
    }
}
