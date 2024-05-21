using System;// файл юзает память компа

namespace STO // нэймспейс рабочее пространство
{
    public class car // класс это шаблон который задает стандарт 
        // паблик это тэг для строки который обозначает что она доступна в любой части кода , вне зависимости от класса
        // маркер безопасности , общедоступности 
        // класс может содержать методы , поля и свойства , МЕТОДЫ - функция , а ПОЛЯ - свойства
    {
        public string GovNumber { get; set; } // гос номер , свойство 
        public DateTime TiData { get; set; } // Technical inspection , свойство ( зеленая это значит функция системы) 
        public string TransmissionType { get; set; } // тип коробки передач , свойство

        public car(string govNumber, DateTime tiData, string transmissionType) // тоже свойство 
        {
            GovNumber = govNumber;// присуждение свойствам значения 
            TiData = tiData;
            TransmissionType = transmissionType;
        }
    }
}