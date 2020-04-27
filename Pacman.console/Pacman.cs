class PacmanHero : Character{
    int movesWithInVulnerabilityLeft;
    int eatenBerries;
    public PacmanHero(Character[,] field)
       :base(field) 
    {    }
   public override void Move(int x, int y, ref int eatenBerries){
       if (HasMoved){return;}
        char d = System.Console.ReadKey().KeyChar;
        if (d == 'w'){
            Direction = Direction.Up;
        }
        else if (d == 'd'){
            Direction = Direction.Right;
        }
        else if (d == 's'){
            Direction = Direction.Down;
        }
        else if (d == 'a'){
            Direction = Direction.Left;
        }
        else {System.Console.WriteLine();return;}
        System.Console.WriteLine();
        if (IsInField(x + (int)Direction / 2, y + (int)Direction % 2)){
            if (Field[x + (int)Direction / 2, y + (int)Direction % 2] == null){
                Field[x + (int)Direction / 2, y + (int)Direction % 2] = this;
                Field[x,y] = null;
            }
            else if (Field[x + (int)Direction / 2, y + (int)Direction % 2].GetType() == typeof(Berry)){
                ++eatenBerries;
                Field[x + (int)Direction / 2, y + (int)Direction % 2] = this;
                Field[x,y] = null;
            }
        }
        HasMoved = true;
    }
    private bool IsInField(int x, int y){
        return x >= 0 && x <Field.GetLength(1) && y >= 0 && y < Field.GetLength(0);
    }
    public override void Draw(){
        System.Console.Write("P");
        HasMoved = false;
    }
}