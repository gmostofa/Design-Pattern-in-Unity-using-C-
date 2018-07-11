using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDemo : MonoBehaviour
{

    void Start()
    {
        Car ferrari = new Car(1, "Ferarri");
        Bike gixxer = new Bike(2, "Gixxer");

        Car lambourgini = (Car)ferrari.Clone();
        Bike honda = (Bike)gixxer.Clone();

		ferrari.SetVehicle();
		lambourgini.SetVehicle();

		gixxer.SetVehicle();
		honda.SetVehicle();
    }
}
