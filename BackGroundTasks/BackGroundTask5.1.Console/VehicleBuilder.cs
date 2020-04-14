 class VehicleBuilder
{
    Vehicle vehicle = new Vehicle();
    public VehicleBuilder BuildName(string name){
        vehicle.Name = name;
        return this;
    }
    public VehicleBuilder BuildFuelConsumption(double fuelConsumption){
        vehicle.FuelConsumption = fuelConsumption;
        return this;
    }
    public VehicleBuilder BuildFuelTankCapacity(double fuelTankCapacity){
        vehicle.FuelTankCapacity = fuelTankCapacity;
        return this;
    }
    public  Vehicle GetResult(){
        return vehicle;
    }
}