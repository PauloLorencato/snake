using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using Snake;

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
    public void Control(ref NewSnake snake, int speed)
    {
        void Move(int coord1, int coord2)
        {
            Direction[0] = coord1;
            Direction[1] = coord2;
        }
        
        
        string command;
        while(true)
        {   
            if(Console.KeyAvailable)
            {
                command = Console.ReadKey(true).Key.ToString();
                Console.WriteLine("Novo comando: " + command);
                switch(command)
                {
                    case "P":
                        Move(0, 0);
                        break;
                    case "W":
                        if(Direction[0] != 1 && Direction[1] != 0)
                        {
                            Move(-1,0);
                        }                    
                        break;
                    case "A":
                        if(Direction[0] != 0 && Direction[1] != 1)
                        {
                            Move(0,-1);
                        }                    
                        break;
                    case "S":
                        if(Direction[0] != -1 && Direction[1] != 0)
                        {
                            Move(1, 0);
                        }                    
                        break;
                    case "D":
                        if(Direction[0] != 0 && Direction[1] != -1)
                        {
                            Move(0, 1);
                        }                    
                        break;
                    default:
                        break;        
                }
                Thread.Sleep(1000);
            }                     
            
        }
        
    }
    
}