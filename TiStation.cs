using System;
using System.Collections.Generic;
using System.Linq;

namespace STO
{
    public class TiStation
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddCar(Car car)
        {
            vehicles.Add(car);
        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            vehicles.Add(motorcycle);
        }

        public List<Vehicle> Schedule()
        {
            return vehicles;
        }
    }
}
