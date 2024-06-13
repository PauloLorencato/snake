using System.Dynamic;

namespace Control;

public class NewControl
{
    public int[] Direction;

    public NewControl()
    {
        Direction = new int[2];
        Direction[0] = 0;
        Direction[1] = 1;
    }
    public void SetSnake(string control, ref int[,] snake)
    {
        switch(control)
    {
        case "q":
            
            break;
        case "p":
            //open menu
            break;
        case "w":
            //go up
            break;
        case "a":
            //go up
            break;
        case "s":
            //go up
            break;
        case "d":
            //go up
            break;
        case "":
            break;
        
    }
    }
}