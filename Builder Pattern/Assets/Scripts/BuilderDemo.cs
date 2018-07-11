using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderDemo : MonoBehaviour {
	VehicleDirector vehicleDirector;

	void Awake()
	{
		vehicleDirector = new VehicleDirector();
	}
	void Start()
	{
		VehicleBuilderBase carBuilder = new CarBuilder();
		VehicleBuilderBase bikeBuilder = new BikeBuilder();

		vehicleDirector.Construct(carBuilder);
		vehicleDirector.Construct(bikeBuilder);

		Vehicle carInfo = carBuilder.GetVehicle();
		Vehicle bikeInfo = bikeBuilder.GetVehicle();


		Debug.Log(carInfo.VehicleName+ " got "+carInfo.VehicleParts.Count +" parts");
		Debug.Log(bikeInfo.VehicleName+ " got "+bikeInfo.VehicleParts.Count +" parts");
	}
}
