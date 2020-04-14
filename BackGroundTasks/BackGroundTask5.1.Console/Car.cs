class Car : Vehicle
{
    Coachbuiled coachbuiled;
    int numberOfPassengers;
    static readonly int passengersCapacity = 7;
    public Car(){   }
    public Car(Car other){
        this.NumberOfPassengers = other.NumberOfPassengers;
        this.Coachbuiled = other.Coachbuiled;
    }
    public Coachbuiled Coachbuiled{
        get => coachbuiled;
        set => coachbuiled = value;
    }
     public int NumberOfPassengers{
        get => numberOfPassengers;
        set{
            if (value > PassengersCapacity){
                throw new TooManyPassengersException();
            }
            numberOfPassengers = value;
        }
    }
    public int PassengersCapacity{
        get => passengersCapacity;
    }
    public override double LoadFactor{
        get =>  ((double)NumberOfPassengers / (double)PassengersCapacity);
    }
    public override double RequiredFuel(double distance){
        return base.RequiredFuel(distance) / LoadFactor;
    }
}