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
             if (car == null)
             {
                 throw new NullReferenceException("NO");
             }

            vehicles.Add(car);
        }

        public void AddMotorcycle(Motorcycle motorcycle)
            
        {
            if (motorcycle == null)
             {
                 throw new NullReferenceException("NO");
             }

            vehicles.Add(motorcycle);
        }

        public List<Vehicle> Schedule()
        {
            return vehicles;
        }
    }
}
