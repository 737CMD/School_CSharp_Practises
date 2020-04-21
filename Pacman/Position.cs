class Position{
    int x,  y;
    public Position(){     }
    public int X{
        get => x;
        set => x = value;
    }
    public int Y{
        get => y;
        set => y = value;
    }
    public override bool Equals(Position other){
        return other.X == this.X && other.Y == this.Y;
    }
}