using System.Data.Common;

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

        public static Vector operator + (Vector a , Vector b)
        {
            return new Vector
            {
                x = a.x + b.x,
                y = a.y + b.y
            };
        }
    }
    class Obj
    {
        public int value;
        
        public static Obj operator + (Obj a , Obj b)
        {
            return new Obj
            {
                value = a.value + b.value
            };
        }
    }
}