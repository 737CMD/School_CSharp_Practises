abstract class Character{
    Direction direction;
    Position position;
    public Character(){ 
        position = new Position();
        direction = new Direction();
      }
    public Position Position{
        get => position;
        set => position = value;
    }
    public Direction Direction{
        get => direction;
        set => direction = value;
    }
    public abstract void Move();
    public abstract void Draw();
}