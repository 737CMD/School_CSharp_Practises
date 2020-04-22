class Ghost : Character{
    public Ghost(Character[,] field)
        :base(field)
    {}
     public override void Move(int x, int y){
         if (HasMoved){return;}
         System.Random rnd = new System.Random();
         Direction previousDirection = this.Direction;
         int[] directions = {2, 1, -1, -2};
         while (!(IsInField(x + (int)Direction / 2, y + (int)Direction % 2) && (Field[x + (int)Direction / 2, y + (int)Direction % 2] == null || Field[x + (int)Direction / 2, y + (int)Direction % 2].IsBerry))){
             Direction = (Direction)(directions[rnd.Next(4)]);
         }
         if (IsInField(x + (int)Direction / 2, y + (int)Direction % 2)){
            if (Field[x + (int)Direction / 2, y + (int)Direction % 2] == null){
                Field[x + (int)Direction / 2, y + (int)Direction % 2] = this;
                Field[x,y] = null;
            }
            else if (Field[x + (int)Direction / 2, y + (int)Direction % 2].IsBerry){
                ++PacmanHero.EatenBerries;
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