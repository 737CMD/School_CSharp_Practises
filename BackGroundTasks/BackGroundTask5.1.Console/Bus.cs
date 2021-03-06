class Bus : Vehicle
{
    int numberOfPassengers;
    int passengersCapacity;
    int ticketPrice;
    public Bus(){       }
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
        set{
            if (value < NumberOfPassengers){
                throw new TooManyPassengersException();
            }
            passengersCapacity = value;
        }
    }
     public override double RequiredFuel(double distance){
        return base.RequiredFuel(distance) / LoadFactor;
    }
    public double LoadFactor{
        get =>  ((double)NumberOfPassengers / (double)PassengersCapacity);
    } 

}