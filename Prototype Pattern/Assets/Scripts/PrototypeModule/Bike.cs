using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : VehicleBase
{

    public Bike(int id, string name) : base(id, name)
    {

    }
    public override VehicleBase Clone()
    {
        return (VehicleBase)this.MemberwiseClone();
    }

    public override void SetVehicle()
    {
        Debug.Log("Bike Set Up Done");
    }
}
