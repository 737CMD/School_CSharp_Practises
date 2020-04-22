class Wall : Character{
    public Wall(Character[,] field)
        :base(field)
    {   }
     public override void Move(int x, int y){    }
    public override void Draw(){
        System.Console.Write("☐");
    }
}