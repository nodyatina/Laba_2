using System;

namespace STO 
{
    public class car 
        
    {
        public string GovNumber { get; set; } 
        public DateTime TiData { get; set; } 
        public string TransmissionType { get; set; } 

        public car(string govNumber, DateTime tiData, string transmissionType) 
        {
            GovNumber = govNumber;
            TiData = tiData;
            TransmissionType = transmissionType;
        }
    }
}
