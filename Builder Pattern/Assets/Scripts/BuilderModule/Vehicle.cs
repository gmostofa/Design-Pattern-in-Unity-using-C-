using System.Collections.Generic;

[System.Serializable]
public class Vehicle
{
    string vehicleName;
    List<string> vehicleParts;
    public string VehicleName
    {
        get
        {
            return vehicleName;
        }
    }
    public List<string> VehicleParts
    {
        get
        {
            return vehicleParts;
        }
    }
	public Vehicle()
	{
		vehicleParts = new List<string>();
	}

    public void AddVehicleParts(string vehiclePartsName)
    {
        vehicleParts.Add(vehiclePartsName);
    }
    public void CreateVehicle(string vehicleName)
    {
        this.vehicleName = vehicleName;
    }

}
