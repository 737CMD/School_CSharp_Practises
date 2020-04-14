
 class Vehicle
{
    protected string name;
    protected double fuelConsumption;
    protected double fuelTankCapacity;
    public Vehicle(){
        Name = "NikolaiRecrutMachinaEMae";
        FuelConsumption = 42;
        FuelTankCapacity = 420;
    }

    public string Name {
        get => name;
        set => name = value;
        }
     public double FuelConsumption {
        get => fuelConsumption;
        set => fuelConsumption = value;
    }
    public double FuelTankCapacity {
        get => fuelTankCapacity; 
        set => fuelTankCapacity = value;
    }
    public double GetMaximumDistance{
        get => FuelTankCapacity / FuelConsumption;
    }
    public virtual double RequiredFuel(double distance){
        return distance * FuelConsumption;
    }
}