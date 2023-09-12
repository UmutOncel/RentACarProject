using RentACar.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        //public Customer Customer { get; set; }
        //public int CustomerID { get; set; }
        public CarPark? CarPark { get; set; }
        public int? CarParkID { get; set; }
        public virtual ICollection<CarCustomer> CarCustomers { get; set; }
        public Car()
        {
            CarCustomers = new HashSet<CarCustomer>();
        }
        public CarModel CarModel { get; set; }
    }
}
