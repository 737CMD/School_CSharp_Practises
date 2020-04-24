abstract class Character{
    Direction direction;
    protected bool HasMoved;
    Character[,] field;
    public Character(Character[,] field){ 
        direction = Direction.Right;
        this.field = field;
      }
    public Direction Direction{
        get => direction;
        set => direction = value;
    }
    public Character[,] Field{
            get => field;
    }
    public virtual void Move(int x, int y, ref int eatenBerries){}
    public abstract void Draw();
}