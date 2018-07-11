using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : VehicleBase
{
    public Car(int id, string name) : base(id, name)
    {

    }
    public override VehicleBase Clone()
    {
        return (VehicleBase)this.MemberwiseClone();
    }

    public override void SetVehicle()
    {
        Debug.Log("Car Set Up Done");
    }
}
