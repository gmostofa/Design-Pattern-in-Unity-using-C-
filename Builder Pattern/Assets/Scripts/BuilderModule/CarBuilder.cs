public class CarBuilder : VehicleBuilderBase
{
    Vehicle car = new Vehicle();

    public override void BuildParts()
    {
        car.AddVehicleParts("Car_Body");
        car.AddVehicleParts("Car_Seats");
    }

    public override void BuildVehicle()
    {
        car.CreateVehicle("Ferari");
    }

    public override Vehicle GetVehicle()
    {
        return car;
    }
}