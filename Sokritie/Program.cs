namespace Sokritie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Display();
            b.Display();
            ((A)b).Display();

            c.Display();
            ((A)c).Display();
           

            Console.WriteLine("New cod");
            
            D d = new D();
            E e = new E();
            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
        }
    }

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Metod A");
        }
    }
    class B : A 
    {
        public override void Display()
        {
            Console.WriteLine("Metod B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("Metod C");
        }
    }
    class D : B
    {
        public void Display()
        {
            Console.WriteLine("Metod D");
        }
    }
    class E : C
    {
        public void Display()
        {
            Console.WriteLine("Metod E");
        }
    }
}