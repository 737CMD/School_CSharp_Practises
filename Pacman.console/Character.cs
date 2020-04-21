abstract class Character{
    Direction direction;
    Character[] field;
    public Character(Character[] field){ 
        direction = new Direction();
        this.field = field;
      }
    public Direction Direction{
        get => direction;
        set => direction = value;
    }
    public Character[] Field{
            get => field;
    }
    public abstract void Move(int x, int y);
    public abstract void Draw();
}