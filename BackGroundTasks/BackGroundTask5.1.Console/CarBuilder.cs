class CarBuilder 
{
    Car car = new Car();
    public CarBuilder BuildCoachbuiled(Coachbuiled coachbuiled){
        car.Coachbuiled = coachbuiled;
        return this;
    }
    public CarBuilder BuildNumberOfPassengers(int numberOfPassengers){
        car.NumberOfPassengers = numberOfPassengers;
        return this;
    }
    public CarBuilder BuildPassengersCapacity(int passengersCapacity){
        car.PassengersCapacity = passengersCapacity;
        return this;
    }
    public CarBuilder BuildName(string name){
        car.Name = name;
        return this;
    }
    public CarBuilder BuildFuelConsumption(double fuelConsumption){
        car.FuelConsumption = fuelConsumption;
        return this;
    }
    public CarBuilder BuildFuelTankCapacity(double fuelTankCapacity){
        car.FuelTankCapacity = fuelTankCapacity;
        return this;
    }
    public  Car GetResult(){
        return car;
    }

}