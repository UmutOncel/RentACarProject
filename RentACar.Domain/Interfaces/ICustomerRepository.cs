using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Interfaces
{
    public interface ICustomerRepository:IBaseRepository
    {
        void Create(Customer Customer);
        void Update(Customer Customer);
        Customer GetById(int id);
        List<Customer> GetAll();
    }
}
