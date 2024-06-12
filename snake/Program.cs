using Frame;
using Snake;
using Food;
using Control;
using Microsoft.VisualBasic;
using System.Data;
using System.Reflection.Metadata.Ecma335;

NewSnake snake = new NewSnake();
NewFrame newFrame = new NewFrame();
NewFood newFood = new NewFood();
NewControl control = new NewControl();

int speed = 1000;

snake.SnakeBody = snake.CreateSnake();


bool running = true;
while (running)
{
    //if food was eaten in last frame
    if(newFood.IsEaten == true)
    {
        newFood.CreateFood();
        string foodPlace = newFood.Place[0].ToString() + "," + newFood.Place[1].ToString();
        while(Array.IndexOf(snake.Changes, foodPlace) != -1)
        {
            newFood.CreateFood();
            foodPlace = newFood.Place[0].ToString() + "," + newFood.Place[1].ToString();
        }
        newFood.IsEaten = false;
    }

    //set snake movement by direction

    //if snake eats food, increase snake and set IsEaten as true

    //if snake hits wall, die (finish program)

    
    newFrame.DrawFrame(ref snake.SnakeBody, ref newFood.Place);

    //update command or run next interaction
    string command = "";
    int waiting = 0;
    while(waiting <= speed)
    {
        if(Console.KeyAvailable)
        {
            command = Console.ReadKey(false).ToString();
        }
        Thread.Sleep(50);
        waiting += 50;
    }
    Console.WriteLine(command);

    Console.Clear();
}