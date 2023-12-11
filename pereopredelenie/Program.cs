using System.Security.Cryptography.X509Certificates;

namespace pereopredelenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    class baseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Metod baseClass");
        }
    }
    class DerivedClass : baseClass 
    {
        public override void Display()
        {
            Console.WriteLine("Metod DerivedClass");
        }
    }
}