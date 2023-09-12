using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastname { get; set; }
        //public virtual ICollection<Car> Cars { get; set; }
        public Customer()
        {
            //Cars = new HashSet<Car>();
            CarCustomers = new HashSet<CarCustomer>();
        }
        public virtual ICollection<CarCustomer> CarCustomers { get; set; }
    }
}
