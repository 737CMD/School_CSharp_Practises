class Bus : Vehicle
{
    int numberOfPassengers;
    static readonly int passengersCapacity = 77;
    int ticketPrice;
    public Bus(){
        this.TicketPrice = 42;
        this.NumberOfPassengers = 42;
       }
    public Bus(Bus other){
        this.TicketPrice = other.TicketPrice;
        this.NumberOfPassengers = other.NumberOfPassengers;
    }
    public int TravelProfit{
        get => TicketPrice * NumberOfPassengers;
    }
    public int NumberOfPassengers{
        get => numberOfPassengers;
        set{
            if (value > PassengersCapacity){
                throw new TooManyPassengersException("Davka e mae");
            }
            numberOfPassengers = value;
        }
    }
    public int TicketPrice{
        get => ticketPrice;
        set => ticketPrice = value;
    }
    public int PassengersCapacity{
        get => passengersCapacity;
    }
     public override double RequiredFuel(double distance){
        return base.RequiredFuel(distance) / LoadFactor;
    }
    public override double LoadFactor{
        get =>  ((double)NumberOfPassengers / (double)PassengersCapacity);
    } 

}