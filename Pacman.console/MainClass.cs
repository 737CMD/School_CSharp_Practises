
namespace Pacman.console
{
    class Program
    {
        static void Main(string[] args)
        {
           Field field=  new Field(10, 10);
           field.FillField();
           field.Game();
        }
    }
}
