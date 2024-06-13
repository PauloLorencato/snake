using System.Globalization;

namespace Snake
{
    public class NewSnake
    {
        private const string dot = "88";

        public string[,] SnakeBody;
        public List<int[]> Changes;
        public int[] Direction;

        public NewSnake()
        {
            SnakeBody = new string[15,15];
            Changes = new List<int[]>();
            Direction = new int[2];
            Direction[0] = 0;
            Direction[1] = 1;
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
            int[] bounds = Changes[^1];
            if(bounds[0] >= 14 || bounds[0] <= 0 || bounds[1] >=14 || bounds[1] <= 0)
            {
                return;
            }
            int[] coords = new int[2];
            coords[0] = Changes[^1][0] + direction[0];
            coords[1] = Changes[^1][1] + direction[1];
            SnakeBody[coords[0], coords[1]] = dot;
            Changes.Add(coords);
            if(!ate)
            {
                SnakeBody[Changes[0][0], Changes[0][1]] = "";
                Changes.RemoveAt(0);
            }
            return;
        }
    }
}