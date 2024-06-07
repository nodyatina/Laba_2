using System;

namespace STO 
{
    public class Car : Vehicle
    {
        public string TransmissionType { get; set; }

        public Car(string govNumber, DateTime tiData, string transmissionType)
        {            
             if (string.IsNullOrEmpty(govNumber)) throw new ArgumentNullException(nameof(govNumber), "GovNumber cannot be null or empty.");
            GovNumber = govNumber;
            TiData = tiData;
            TransmissionType = transmissionType;
        }
    }
