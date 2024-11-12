using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalConsoleApp.Models
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Vin { get; set; }
        public string PlateNumber { get; set; }

        public Vehicle(int id, string make, string model, int year, int vin, string plateNumber)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Vin = vin;
            PlateNumber = plateNumber;
        }
    }
}
    