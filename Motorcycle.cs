using System;

namespace STO
{
   public class Motorcycle : Vehicle
    {
        public string MotoType { get; set; }

        public Motorcycle(string govNumber, DateTime tiData, string motoType)
        {
            if (string.IsNullOrEmpty(govNumber)) throw new ArgumentNullException(nameof(govNumber), "GovNumber cannot be null or empty.");

            GovNumber = govNumber;
            TiData = tiData;
            MotoType = motoType;
        }
    }
