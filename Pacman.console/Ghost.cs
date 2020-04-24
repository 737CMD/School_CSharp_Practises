class Ghost : Character{
    public Ghost(Character[,] field)
        :base(field)
    {}
     public override void Move(int x, int y, ref int eatenBerries){
         if (HasMoved){return;}
         System.Random rnd = new System.Random();
         Direction previousDirection = this.Direction;
         int[] directions = {2, 1, -1, -2};
         if (IsInField(x + (int)Direction / 2, y + (int)Direction % 2) && Field[x + (int)Direction / 2, y + (int)Direction % 2] != null && typeof(PacmanHero) == Field[x + (int)Direction / 2, y + (int)Direction % 2].GetType()){
             throw new PacmanEaten();
         }
         while (!(IsInField(x + (int)Direction / 2, y + (int)Direction % 2) && (Field[x + (int)Direction / 2, y + (int)Direction % 2] == null || Field[x + (int)Direction / 2, y + (int)Direction % 2].GetType() == typeof(Berry)))){
             Direction = (Direction)(directions[rnd.Next(4)]);
         }
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
         Field[x + (int)Direction / 2, y + (int)Direction % 2] = this;
         Field[x, y] = null;
         HasMoved = true;
     }
    bool IsInField(int x, int y){
        return x >= 0 && x <Field.GetLength(1) && y >= 0 && y < Field.GetLength(0);
    }
         
   public override void Draw(){
        System.Console.Write("G");
        HasMoved = false;
    }
}