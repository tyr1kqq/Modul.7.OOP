namespace Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector { x = 2, y = 6 };
            Vector b = new Vector { x = 3, y = 4 };

            Vector c = a.Add(b);

            Console.WriteLine($"{c.x} , {c.y}");
        }
    }
    class Vector
    {
        public int x;
        public int y;

        public Vector Add(Vector second)
        {
            return new Vector
            {
                x = this.x + second.x,
                y = this.y + second.y
            };
        }
    }
}