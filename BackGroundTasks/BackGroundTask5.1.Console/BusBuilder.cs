class BusBuilder{
    Bus bus = new Bus();
    public BusBuilder BuildTickerPrice(int ticketPrice){
        bus.TicketPrice = ticketPrice;
        return this;
    }
    public BusBuilder BuildNumberOfPassengers(int numberOfPassengers){
        bus.NumberOfPassengers = numberOfPassengers;
        return this;
    }
     public BusBuilder BuildName(string name){
        bus.Name = name;
        return this;
    }
    public BusBuilder BuildFuelConsumption(double fuelConsumption){
        bus.FuelConsumption = fuelConsumption;
        return this;
    }
    public BusBuilder BuildFuelTankCapacity(double fuelTankCapacity){
        bus.FuelTankCapacity = fuelTankCapacity;
        return this;
    }
    public  Bus GetResult(){
        return bus;
    }
}