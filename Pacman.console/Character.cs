abstract class Character{
    Direction direction;
    bool isBerry;
    protected bool HasMoved;
    Character[,] field;
    public Character(Character[,] field){ 
        direction = Direction.Right;
        this.field = field;
      }
      public bool IsBerry{
          get => isBerry;
          set => isBerry = value;
      }
    public Direction Direction{
        get => direction;
        set => direction = value;
    }
    public Character[,] Field{
            get => field;
    }
    public virtual void Move(int x, int y){}
    public abstract void Draw();
}