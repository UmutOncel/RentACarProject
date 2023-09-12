using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Interfaces
{
    public interface ICarRepository:IBaseRepository
    {
        void Create(Car car);
        void Update(Car car);
        Car GetById(int id);
        List<Car> GetAll();
    }
}
