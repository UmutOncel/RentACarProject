using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Interfaces
{
    public interface IBaseRepository
    {
        void Delete(int id);
    }
}
