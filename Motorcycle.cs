using System;

namespace STO
{
    public class Motorcycle
    {
        public string GovNumber { get; set; }
        public DateTime TiData { get; set; }
        public string MotoType { get; set; } 

        public Motorcycle(string govNumber, DateTime tiData, string motoType) 
        {
            GovNumber = govNumber;
            TiData = tiData;
            MotoType = motoType;
        }
    }
}
