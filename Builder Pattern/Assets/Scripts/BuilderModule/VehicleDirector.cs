using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleDirector
{
    public void Construct(VehicleBuilderBase vehicle)
    {
        vehicle.BuildVehicle();
        vehicle.BuildParts();
    }
}
