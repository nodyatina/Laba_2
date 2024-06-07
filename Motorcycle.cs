using System;

namespace STO
{
   public class Motorcycle : Vehicle
    {
        public string MotoType { get; set; }

        public Motorcycle(string govNumber, DateTime tiData, string motoType)
        {
            GovNumber = govNumber ?? throw new ArgumentNullException( "cannot be null");;
            TiData = tiData ?? throw new ArgumentNullException( "cannot be null");;
            MotoType = motoType ?? throw new ArgumentNullException( "cannot be null");;
        }
    }
