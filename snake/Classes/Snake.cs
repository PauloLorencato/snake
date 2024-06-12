using System.Globalization;

namespace Snake
{
    public class NewSnake
    {
        private const string dot = "88";

        public string[,] SnakeBody;
        public string[] Changes;
        public int[] Direction;

        public NewSnake()
        {
            SnakeBody = new string[15,15];
            Changes = new string[4];
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
                string[] array = Changes;
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = "8," + i.ToString();
                Changes = array;
            }
            return SnakeBody;
        }
    }
}