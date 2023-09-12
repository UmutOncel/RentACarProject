using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class CarCustomer
    {
        public int CarCustomerID { get; set; }
        public int? CarID { get; set; }
        public Car? Car { get; set; }
        public int? CustomerID { get; set; }
        public Customer? Customer { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
