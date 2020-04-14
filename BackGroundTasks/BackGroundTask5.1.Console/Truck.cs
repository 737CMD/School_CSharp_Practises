class Truck : Vehicle
{
    double carryingCapacity;
    double cargoWeight;
    public Truck() {    }
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
    public double LoadFactor{
        get => CargoWeight / CarryingCapacity;
    }
}