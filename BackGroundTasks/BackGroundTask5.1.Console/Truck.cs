class Truck : Vehicle
{
    double carryingCapacity;
    double cargoWeight;
    public Truck() {    }
    public Truck(Truck other){
        this.CargoWeight = other.CargoWeight;
        this.CarryingCapacity = other.CarryingCapacity; 
    }
    public override double RequiredFuel(double distance){
        return base.RequiredFuel(distance) * LoadFactor;
    }
    public double CargoWeight{
        get => cargoWeight;
        set{
            if (value > CarryingCapacity){
                throw new TooHeavyCargoException("Ne edet kamaz, razgruzhay");
            }
            cargoWeight = value;
        }
    }
    public double CarryingCapacity{
        get => carryingCapacity;
        set{
            if (CargoWeight > value){
                throw new TooHeavyCargoException("Ne edet kamaz, razgruzhay");
            }
            carryingCapacity = value;
        }
    }
    public override double LoadFactor{
        get => CargoWeight / CarryingCapacity;
    }

}