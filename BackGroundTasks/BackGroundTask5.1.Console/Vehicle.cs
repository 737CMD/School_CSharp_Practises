
abstract class Vehicle
{
    protected string name;
    protected double fuelConsumption;
    protected double fuelTankCapacity;
    public Vehicle(){
        Name = "NikolaiRecrutMachinaEMae";
        FuelConsumption = 42;
        FuelTankCapacity = 420;
    }
    public Vehicle(Vehicle other){
        this.Name = other.Name;
        this.FuelConsumption = other.FuelConsumption;
        this.FuelTankCapacity = other.FuelTankCapacity;
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
        get => fuelConsumption /  fuelTankCapacity;
    }
    public virtual double GetRequiredFuel(double distance){
        return distance * fuelConsumption;
    }
    public abstract double LoadFactor();
}