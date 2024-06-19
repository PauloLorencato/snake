using Snake;

namespace Food
{
    public class NewFood
    {
        public int[] Place;
        public bool IsEaten;

        public void CreateFood()
        {
            Place = new int[2];
            var coord = new Random();
            Place[0] = coord.Next(15);
            Place[1] = coord.Next(15);
            IsEaten = false;
        }
        public NewFood()
        {
            CreateFood();
        }

        public void AteFood(ref NewSnake snake)
        {
            if(IsEaten == true)
            {
                CreateFood();
                while(snake.Changes.IndexOf(Place) != -1)
                {
                    CreateFood();
                }
            }
        }
    }
}