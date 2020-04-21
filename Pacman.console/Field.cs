class Field{
    readonly int fieldHeight;
    readonly int fieldWidth;
    Character[,] field;
    public Field(int fieldHeight, int fieldWidth){
        this.fieldHeight = fieldHeight;
        this.fieldWidth = fieldWidth;
        field = new Character[FieldHeight, FieldWidth];
    }
    public int FieldHeight{
        get => fieldHeight;
    }
    public int FieldWidth{
        get => fieldWidth;
    }
    public void FillField(){
    }
}