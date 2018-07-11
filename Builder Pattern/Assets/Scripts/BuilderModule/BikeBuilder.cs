public class BikeBuilder : VehicleBuilderBase
{
     Vehicle bike = new Vehicle();

    public override void BuildParts()
    {
        bike.AddVehicleParts("Bike_Body");
        bike.AddVehicleParts("Bike_Seats");
        bike.AddVehicleParts("Bike_Lights");
    }

    public override void BuildVehicle()
    {
        bike.CreateVehicle("Gixxer");
    }

    public override Vehicle GetVehicle()
    {
        return bike;
    }
}