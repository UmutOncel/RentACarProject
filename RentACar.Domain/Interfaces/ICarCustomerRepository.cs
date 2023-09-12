using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Interfaces
{
    public interface ICarCustomerRepository:IBaseRepository
    {
        void Create(CarCustomer carCustomer);
        void Update(CarCustomer carCustomer);
        CarCustomer GetById(int id);
        List<CarCustomer> GetAll();
    }
}
