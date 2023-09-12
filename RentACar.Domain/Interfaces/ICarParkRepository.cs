using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Interfaces
{
    public interface ICarParkRepository:IBaseRepository
    {
        void Create(CarPark carPark);
        void Update(CarPark carPark);
        CarPark GetById(int id);
        List<CarPark> GetAll();
    }
}
