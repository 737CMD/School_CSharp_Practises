class PacmanHero : Character{
    int movesWithInVulnerabilityLeft;
    public PacmanHero(Field field)
       :base(field) 
    {    }
    public int movesWithInulnerabilityLeft{
        get => movesWithInulnerabilityLeft;
        set => movesWithInVulnerabilityLeft = value;
    }
    public override void Move(){

    }
    public override void Draw(){
        System.Console.Write("P");
    }
}