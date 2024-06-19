namespace Frame;
public class NewFrame
    {
        public string Control;
        public NewFrame()
        {
            Control = "";
        }
        public void DrawFrame(ref string[,] snake, ref int[] food)
        {
            Console.WriteLine();
            Console.WriteLine("________________________________");
            for (int i = 0; i < 15; i += 1)
            {
                Console.Write("|");
            for(int j = 0; j < 15; j += 1)
            {
                if(snake[i,j] != "")
                {
                    Console.Write(snake[i,j]);
                }                
                else if(i == food[0] && j == food[1])
                {
                    Console.Write("db");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine("|");
            }
            Console.WriteLine("________________________________");
            return;
        }
    }
    