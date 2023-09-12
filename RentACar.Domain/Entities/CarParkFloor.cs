using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class CarParkFloor
    {
        public int CarParkFloorID { get; set; }
        public int CarParkFloorNo { get; set; }
        public virtual ICollection<CarPark> CarParks { get; set; }
        public CarParkFloor()
        {
            CarParks = new HashSet<CarPark>();
        }
    }
}
