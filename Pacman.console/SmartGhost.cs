class SmartGhost : Character{
    public SmartGhost(Character[,] field)
        :base(field)
    {   }
     public void Move(int x, int y, int PacmanX, int pacmanY){
    } 
    public override void Draw(){
        System.Console.Write("S");
    }
}