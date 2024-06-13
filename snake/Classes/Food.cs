namespace Food
{
    public class NewFood
    {
        public int[] Place;
        public bool IsEaten;

        public NewFood()
        {
            Place = new int[2];
            Random coord = new();
            Place[0] = coord.Next(15);
            Place[1] = coord.Next(15);
            IsEaten = false;
        }

        public void CreateFood()
        {
            Place = new int[2];
            var coord = new Random();
            Place[0] = coord.Next(15);
            Place[1] = coord.Next(15);
            IsEaten = false;
        }
    }
}