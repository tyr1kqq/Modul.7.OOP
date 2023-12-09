namespace _7._1._14.Modul._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
     
    }
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProgectManeger : Employee
    {
        public string ProjectName;
    }
    class Developer : Employee
    {
        private string ProgrammingLanguage;
    }

    class Food { }

    class Fruit : Food { }
    class Vegetable : Food { } 
    class Aple : Fruit { }
    class Banana : Fruit { }
    class Pear : Fruit { }
    class Potato : Vegetable { }
    class  Carrot : Vegetable { }

    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass 
    {
        public string Description;

        public int Counter;
        public DerivedClass(string name,string description) : base(name)
        {
            Description = description;
        }
        public DerivedClass(string description, int counter , string name) : base(name) 
        {
            Description = description;
            Counter = counter;
        }
    }

}





