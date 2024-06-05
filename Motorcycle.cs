using System;

namespace STO
{
   public class Motorcycle : Vehicle
    {
        public string MotoType { get; set; }

        public Motorcycle(string govNumber, DateTime tiData, string motoType)
        {
            GovNumber = govNumber;
            TiData = tiData;
            MotoType = motoType;
        }
    }
