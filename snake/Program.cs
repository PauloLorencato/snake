using Frame;
using Snake;
using Food;
using Control;
using Microsoft.VisualBasic;

NewSnake snake = new NewSnake();
NewFrame newFrame = new NewFrame();
NewFood newFood = new NewFood();
NewControl control = new NewControl();

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



    newFrame.DrawFrame(ref snake.SnakeBody, ref newFood.Place);
    string command = Console.ReadKey().ToString() ?? "";
    Console.WriteLine(command);
    Console.Clear();
}