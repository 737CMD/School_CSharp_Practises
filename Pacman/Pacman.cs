class Pacman : Character{
    int movesWithInVulnerabilityLeft;
    public Pacman(){    }
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