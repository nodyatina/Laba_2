using System;
using System.Collections.Generic;
using System.Linq;

namespace STO
{
    public class TiStation
    {
        private List<Car> cars;
        private List<Motorcycle> motorcycles;

        public TiStation()
        {
            cars = new List<Car>();
            motorcycles = new List<Motorcycle>();
        }

        public void AddCar(Car car)
        {
            if (car != null)
            {
                cars.Add(car);
            }
            else
            {
                throw new ArgumentNullException("car", "Cannot add a null car to the station.");
            }
        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            if (motorcycle != null)
            {
                motorcycles.Add(motorcycle);
            }
            else
            {
                throw new ArgumentNullException("motorcycle", "Cannot add a null motorcycle to the station.");
            }
        }

        public IEnumerable<Vehicle> Schedule()
        {
            List<Vehicle> schedule = new List<Vehicle>();
            schedule.AddRange(cars);
            schedule.AddRange(motorcycles);
            schedule.Sort((x, y) => x.TiData.CompareTo(y.TiData));
            return schedule;
        }
    }
}
