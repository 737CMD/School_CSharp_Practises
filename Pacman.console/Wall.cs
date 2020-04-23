class Wall : Character{
    public Wall(Character[,] field)
        :base(field)
    {   }
    public override void Draw(){
        System.Console.Write("☐");
    }
}