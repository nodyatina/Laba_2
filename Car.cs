using System;

namespace STO 
{
    public class Car : Vehicle
    {
        public string TransmissionType { get; set; }

        public Car(string govNumber, DateTime tiData, string transmissionType)
        {
            GovNumber = govNumber;
            TiData = tiData;
            TransmissionType = transmissionType;
        }
    }
