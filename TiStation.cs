using System;
using System.Collections.Generic;
using System.Linq;

namespace STO
{
    public class TiStation
    {
        private List<car> cars; 
        private List<Motorcycle> Motorcycles;

        public TiStation()
        {
            cars = new List<car>();
            Motorcycles = new List<Motorcycle>();
        }

        public void Addcar(car a) 
        {
            cars.Add(a);
        }

        public void AddMotorcycle(Motorcycle m)
        {
            Motorcycles.Add(m);
        }

        public IEnumerable<object> scheduleе()
        {
            var schedule = cars.Cast<object>()
                .Concat(Motorcycles)
                .OrderBy(ts => ((dynamic)ts).TiData)
                .ToList();
            return schedule;  
        }
    }
}
