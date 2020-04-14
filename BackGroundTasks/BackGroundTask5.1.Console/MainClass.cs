namespace BackGroundTask5._1.Console
{
    //При выполнении задания был использован шаблон проектирования "Строитель" для избежания конструктора с большим количеством параметром, так как это было бы антипаттерном
    class MainClass
    {
        static void Main(string[] args)
        {
            Bus bus = new BusBuilder().BuildFuelConsumption(42)
            .BuildFuelTankCapacity(420).BuildName("Anastasia").BuildPassengersCapacity(142)
            .BuildNumberOfPassengers(42).BuildTickerPrice(42)
            .GetResult();
            System.Console.WriteLine(bus.Name);
        }
    }
}
