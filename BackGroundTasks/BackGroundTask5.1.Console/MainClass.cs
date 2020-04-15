namespace BackGroundTask5._1.Console
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Vehicle[] vehiclesArray = new Vehicle[3];
            Car[] carsArray = new Car[3];
            Truck[] trucksArray = new Truck[3];
            Bus[] busesArray = new Bus[3];
            System.Console.WriteLine("Filling vehicle arrays with random values\n");
            for (int i  = 0; i < vehiclesArray.Length; ++i){
                vehiclesArray[i] = new VehicleBuilder().BuildFuelTankCapacity(i * 10).BuildFuelConsumption(i).BuildName("VehicleNikolai" + i).GetResult();
                carsArray[i] = new CarBuilder().BuildCoachbuileder((Coachbuilder) (i % 5)).BuildFuelTankCapacity((i+5) * new System.Random().Next(1, i+5)).BuildFuelConsumption(i).BuildName("CarNikolai" + i).BuildPassengersCapacity(10).BuildNumberOfPassengers(i).GetResult();
                trucksArray[i] = new TruckBuilder().BuildCarryingCapacity(i * 2).BuildCargoWeight(i).BuildFuelTankCapacity(i).BuildFuelConsumption(i).BuildName("TruckNikolai" + i).GetResult();
                busesArray[i] = new BusBuilder().BuildFuelTankCapacity(i * 10).BuildFuelConsumption(i).BuildName("BusNikolai"+ i).BuildPassengersCapacity(i * 10).BuildNumberOfPassengers(i).GetResult();
            }
            foreach(Vehicle vehicle in vehiclesArray){
                System.Console.WriteLine("vehicle.Name:\t" + vehicle.Name);
                System.Console.WriteLine("vehicle.FuelTankCapacity:\t" + vehicle.FuelTankCapacity);
                System.Console.WriteLine("vehicle.FuelConsumption:\t" + vehicle.FuelConsumption);
            }
             System.Console.WriteLine();
            foreach(Car car in carsArray){
                System.Console.WriteLine("car.Name:\t" + car.Name);
                System.Console.WriteLine("car.FuelTankCapacity:\t" + car.FuelTankCapacity);
                System.Console.WriteLine("car.FuelConsumption:\t" + car.FuelConsumption);
                System.Console.WriteLine("car.NumberOfPassengers:\t" + car.NumberOfPassengers);
                System.Console.WriteLine("car.PassengersCapacity:\t" + car.PassengersCapacity);
                System.Console.WriteLine("car.GetMaximumDistance:\t" + car.GetMaximumDistance);
                System.Console.WriteLine("car.FuelConsumption:\t" + car.FuelConsumption);
            }
            System.Console.WriteLine();
            foreach(Truck truck in trucksArray){
                System.Console.WriteLine("truck.Name:\t" + truck.Name);
                System.Console.WriteLine("truck.Name:\t" + truck.FuelTankCapacity);
                System.Console.WriteLine("truck.FuelConsumption:\t" + truck.FuelConsumption);
                System.Console.WriteLine("truck.CargoWeight:\t" + truck.CargoWeight);
                System.Console.WriteLine("truck.CarryingCapacity:\t" + truck.CarryingCapacity);
            }
            System.Console.WriteLine();
            foreach(Bus bus in busesArray){
                System.Console.WriteLine("bus.Name:\t" + bus.Name);
                System.Console.WriteLine("bus.FuelTankCapacity:\t" + bus.FuelTankCapacity);
                System.Console.WriteLine("bus.FuelConsumption:\t" + bus.FuelConsumption);
                System.Console.WriteLine("bus.NumberOfPassengers:\t" + bus.NumberOfPassengers);
                System.Console.WriteLine("bus.PassengersCapacity):\t" + bus.PassengersCapacity);
            }
        }
    }
}
