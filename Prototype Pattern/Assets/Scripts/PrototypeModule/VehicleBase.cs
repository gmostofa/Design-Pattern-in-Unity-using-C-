using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VehicleBase{
	int vehicleId;
	string vehicleName;
	
	public int VehicleId{
		get{
			return vehicleId;
		}set{
			vehicleId = value;
		}
	}
	public string VehicleName{
		get{
			return vehicleName;
		}set{
			vehicleName = value;
		}
	}
	public VehicleBase(int id,string vehicleName)
	{
		this.vehicleId = id;
		this.vehicleName = vehicleName;
	}
	public abstract VehicleBase Clone();
	public abstract void SetVehicle();

	
}
