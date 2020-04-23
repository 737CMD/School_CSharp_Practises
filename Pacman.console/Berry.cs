class Berry : Character{
    public Berry(Character[,] field)
        :base(field){   }
    public override void Draw(){
        System.Console.Write(".");
    }
}