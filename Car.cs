using System;

namespace STO 
{
    public class Car : Vehicle
    {
        public string TransmissionType { get; set; }

        public Car(string govNumber, DateTime tiData, string transmissionType)
        {            
            GovNumber = govNumber ?? throw new ArgumentNullException("cannot be null");
            TiData = tiData ?? throw new ArgumentNullException("cannot be null");;
            TransmissionType = transmissionType ?? throw new ArgumentNullException("cannot be null");;
        }
    }
