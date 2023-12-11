using System.Security.Cryptography.X509Certificates;

namespace Citizen.CivilServant.President
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
    class Citizen
    {
        

        public virtual double Age { get; set; }

        public void SayYourAge()
        {
            Console.WriteLine("My age is - {0}", Age);
        }
        
    }
    class CivilCervan : Citizen
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Your age < 18");
                    age = value;
                }
            }
        }
    }
    class President : Citizen
    {
        private double age;
        public override double Age
        {
            get
            { return age;}
            set
            {
                if (value < 35)
                {
                    Console.WriteLine("Age President > 35");
                    age = value;
                }
            }
        }
    }
    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter
        {
            get { return counter; }
            set
            {
                if (value >= 0)
                {
                    
                    counter = value;
                }
            }
    }
}