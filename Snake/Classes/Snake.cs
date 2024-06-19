using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Food;

namespace Snake
{
    public class NewSnake
    {
        private const string dot = "88";

        public string[,] SnakeBody;
        public List<int[]> Changes;
        public int[] Direction;
        private bool IsDead;

        public NewSnake()
        {
            SnakeBody = new string[15,15];
            Changes = new List<int[]>();
            Direction = new int[2];
            Direction[0] = 0;
            Direction[1] = 1;
            IsDead = false;
        }

        public string[,] CreateSnake()
        {   
            for(int i = 0; i < 15; i += 1)
            {
                for(int j = 0; j < 15; j += 1)
                {
                    SnakeBody[i,j] = "";
                }
            }
            for(int i = 4; i < 8; i += 1)
            {
                SnakeBody[8,i] = dot;
                int[] coords = new int[2];
                coords[0] = 8;
                coords[1] = i;
                Changes.Add(coords);
            }
            return SnakeBody;
        }

        public void MoveSnake(int[] direction, bool ate)
        {
            bool CheckRange(int[] array)
            {
                return array[0] > 14 || array[0] < 0 || array[1] > 14 || array[1] < 0;
            }
            int[] bounds = Changes[^1];
            if(CheckRange(bounds))
            {
                IsDead = true;
                return;
            }
            
            int[] coords = new int[2];
            coords[0] = Changes[^1][0] + direction[0];
            coords[1] = Changes[^1][1] + direction[1];

            for(int i = 0; i < Changes.Count; i += 1)
            {
                if(Changes[i][0] == coords[0] && Changes[i][1] == coords[1])
                {
                    IsDead = true;
                    return;
                }
            }

            if(!CheckRange(coords))
            {
                SnakeBody[coords[0], coords[1]] = dot;
            }            
            Changes.Add(coords);
                        
            if(!ate)
            {
                SnakeBody[Changes[0][0], Changes[0][1]] = "";
                Changes.RemoveAt(0);
            }

            
            return;
        }

        public void FeedSnake(ref NewFood newFood)
        {
            if(Changes[^1][0] == newFood.Place[0] && Changes[^1][1] == newFood.Place[1])
            {
                newFood.IsEaten = true;
            }
        }

        public void KillSnake()
        {
            if(IsDead)
            {
                string gameOver = "G A M E  O V E R";
                int j = 0;
                for(int i = 0; i < gameOver.Length / 2; i += 1)
                {
                    SnakeBody[7,i + 3] = gameOver[j].ToString() + gameOver[j + 1].ToString();

                    j += 2;
                }
            }
        }
    }
}