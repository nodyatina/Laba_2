using System;
using System.Collections.Generic;// мы юзаем отдельные каталоги комп функционала 
using System.Linq;// мы юзаем отдельные каталоги комп функционала 

namespace STO
{
    public class TiStation
    {
        private List<car> cars; // заприваченная штука только в локальном месте кода
        private List<Motorcycle> Motorcycles;

        public TiStation()
        {
            cars = new List<car>();// экземпляр класса , пример бабочки на основе ее шаблона 
            Motorcycles = new List<Motorcycle>();
        }

        public void Addcar(car a) // создаем метод . метод - функция . должна что-то делать. void признак того, что не вернет значение
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
            return schedule; // так как нет воид то возвращает 
        }
    }
}