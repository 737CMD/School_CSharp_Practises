class Berry : Character{
    public Berry(Character[,] field)
        :base(field)
        {
            IsBerry = true;
        } 
    public override void Draw(){
        System.Console.Write(".");
    }
    public override void Move(int x, int y){    }
}