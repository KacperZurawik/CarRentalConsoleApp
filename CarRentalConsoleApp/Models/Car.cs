using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalConsoleApp.Models
{
    public class Car : Vehicle
    {
        public Car(int id, string make, string model, int year, int vin, string plateNumber) : base(id, make, model, year, vin, plateNumber)
        {
            
        }
    }
}
