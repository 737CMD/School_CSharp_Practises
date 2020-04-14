class Truck : Vehicle
{
    double carryingCapacity;
    double cargoWeight;
    public Truck() {    }
    public Truck(Truck other){
        this.CargoWeight = other.CargoWeight;
        this.CarryingCapacity = other.CarryingCapacity; 
    }
    public override double GetRequiredFuel(double distance){
        return base.GetRequiredFuel(distance) / CargoWeight;
    }
    public double CargoWeight{
        get => cargoWeight;
        set => cargoWeight = value;
    }
    public double CarryingCapacity{
        get => carryingCapacity;
        set => carryingCapacity = value;
    }
    public override double LoadFactor(){
        return CargoWeight / CarryingCapacity;
    }

}