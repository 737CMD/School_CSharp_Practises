class Field{
    int eatenBerries;
    readonly Character[,] field;
    public Field(int fieldHeight, int fieldWidth){
        this.FieldHeight = fieldHeight;
        this.FieldWidth = fieldWidth;
        field = new Character[FieldHeight, FieldWidth];
    }

    private int FieldHeight { get; }

    private int FieldWidth { get; }

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
        while (eatenBerries < FieldHeight * FieldWidth - FieldHeight * FieldWidth / 10 - 3){
            for (int y = 0; y < FieldHeight; ++y){
                for (int x = 0; x < FieldWidth; ++x){
                    if (field[x,y] == null){
                        System.Console.Write(" ");
                        continue;
                    }
                    field[x, y].Draw();
                }
            System.Console.WriteLine();
            }
            for (int y = 0; y < FieldHeight; ++y){
                for (int x = 0; x < FieldWidth; ++x){
                     if (field[x,y] != null){
                         try{
                            field[x, y].Move(x ,y, ref eatenBerries);
                         }
                         catch(PacmanEaten){
                           System.Console.WriteLine("GAME OVER");
                           return;  
                         }
                    }
                }
            }
        }
        System.Console.WriteLine();
    }
}