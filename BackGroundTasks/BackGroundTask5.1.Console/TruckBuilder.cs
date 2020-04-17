class TruckBuilder{
    Truck truck;
    public TruckBuilder(){
        truck = new Truck();
    }
    public TruckBuilder BuildCarryingCapacity(int carryingCapacity){
        truck.CarryingCapacity = carryingCapacity;
        return this;
    }
    public TruckBuilder BuildCargoWeight(int cargoWeight){
        truck.CargoWeight = cargoWeight;
        return this;
    }
    public TruckBuilder BuildName(string name){
        truck.Name = name;
        return this;
    }
    public TruckBuilder BuildFuelConsumption(double fuelConsumption){
        truck.FuelConsumption = fuelConsumption;
        return this;
    }
    public TruckBuilder BuildFuelTankCapacity(double fuelTankCapacity){
        truck.FuelTankCapacity = fuelTankCapacity;
        return this;
    }
    public  Truck GetResult(){
        return truck;
    }
}