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
        field[FieldWidth / 2, FieldHeight / 2] = new PacmanHero(field);
        field[0, 0] = new Ghost(field);
        field[FieldWidth - 1, FieldHeight - 1] = new SmartGhost(field);
        int wallToCreate = FieldHeight * FieldWidth / 10;
        System.Random rnd = new System.Random();
        while (wallToCreate > 0)
        {
            int x = rnd.Next(0, FieldWidth);
            int y = rnd.Next(0,FieldHeight);
            if (field[x, y] == null)
            {
                field[x, y] = new Wall(field);
                --wallToCreate;
            }
        }
        for (int x = 0; x < FieldWidth; ++x){
            for (int y = 0; y < FieldHeight; ++y){
                if (field[x, y] == null){
                    field[x, y] = new Berry(field);
                }
            }
        }
    }
    public void Game(){
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (PacmanHero.EatenBerries < FieldHeight * FieldWidth - FieldHeight * FieldWidth / 10 - 3){
            for (int y = 0; y < FieldHeight; ++y){
                for (int x = 0; x < fieldWidth; ++x){
                    if (field[x,y] == null){
                        System.Console.Write(" ");
                        continue;
                    }
                    field[x, y].Draw();
                }
            System.Console.WriteLine();
            }
            for (int y = 0; y < FieldHeight; ++y){
                for (int x = 0; x < fieldWidth; ++x){
                     if (field[x,y ] != null){
                        field[x, y].Move(x ,y);
                    }
                }
            }
        }
        System.Console.WriteLine();
    }
}