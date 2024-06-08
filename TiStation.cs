using System;
using System.Collections.Generic;
using System.Linq;

namespace STO
{
    
        
public class TiStation
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        if (vehicle == null)
        {
            throw new NullReferenceException("Vehicle object is null.");
        }

        vehicles.Add(vehicle);
    }

    public List<Vehicle> Schedule()
    {
        return vehicles;
    }
}
}
