using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Entities
{
    public class CarPark
    {
        public int CarParkID { get; set; }
        public int CarParkNo { get; set; }
        public CarParkFloor? CarParkFloor { get; set; }
        public int? CarParkFloorID { get; set; }
        public Car? Car { get; set; }
    }
}
