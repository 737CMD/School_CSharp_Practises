class Ghost : Character{
    public Ghost(Character[,] field)
        :base(field)
    {}
     public override void Move(int x, int y){
         Direction previousDirection = this.Direction;
          if (IsInField(x + (int)Direction / 2, y + (int)Direction % 2) && (Field[x + (int)Direction / 2, y + (int)Direction % 2] == null || Field[x + (int)Direction / 2, y + (int)Direction % 2].IsBerry)){
              }
         else{
             Direction = (Direction)(3);
              if (IsInField(x + (int)Direction / 2, y + (int)Direction % 2) && (Field[x + (int)Direction / 2, y + (int)Direction % 2] == null || Field[x + (int)Direction / 2, y + (int)Direction % 2].IsBerry)){
              }
                else{
                    Direction = (Direction)(1);
                    if (IsInField(x + (int)Direction / 2, y + (int)Direction % 2) && (Field[x + (int)Direction / 2, y + (int)Direction % 2] == null || Field[x + (int)Direction / 2, y + (int)Direction % 2].IsBerry)){
                    }
                    else{
                        Direction = (Direction)(-1);
                        if (IsInField(x + (int)Direction / 2, y + (int)Direction % 2) && (Field[x + (int)Direction / 2, y + (int)Direction % 2] == null || Field[x + (int)Direction / 2, y + (int)Direction % 2].IsBerry)){
                        }
                        else{
                            Direction = (Direction)(-3);
                            if (IsInField(x + (int)Direction / 2, y + (int)Direction % 2) && (Field[x + (int)Direction / 2, y + (int)Direction % 2] == null || Field[x + (int)Direction / 2, y + (int)Direction % 2].IsBerry)){
                             }
                             else{
                                 Direction = (Direction)((int)previousDirection * -1);
                             }
                        }
                    }
              }
         }
        x += (int)Direction / 2;
        y += (int)Direction % 2;
     }
     bool IsInField(int x, int y){
        return x >= 0 && y < 10 && x >= 0 && y < 10;
    }
         
   public override void Draw(){
        System.Console.Write("G");
    }
}