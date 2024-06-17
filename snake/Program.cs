using Frame;
using Snake;
using Food;
using Control;
using Microsoft.VisualBasic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

int speed = 1000;

NewSnake snake = new NewSnake();
NewFrame newFrame = new NewFrame();
NewFood newFood = new NewFood();
NewControl control = new NewControl();
Thread controlThread = new Thread(new ThreadStart(() => control.Control(ref snake, speed)));



snake.SnakeBody = snake.CreateSnake();


bool running = true;
controlThread.Start();
while (running)
{
    //if snake hits wall, die (finish program)
    snake.KillSnake();

    //if snake eats food, increase snake and set IsEaten as true
    snake.FeedSnake(ref newFood);      

    //set snake movement by direction
    snake.MoveSnake(control.Direction, newFood.IsEaten);
    
    //if food was eaten in last frame
    newFood.AteFood(ref snake);    

    //print current game state to frame
    newFrame.DrawFrame(ref snake.SnakeBody, ref newFood.Place);
    
    Thread.Sleep(speed);
    Console.Clear();
}