namespace Modul._7.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new HybridCar();
            car.Move();
        }

    }
    class Car
    {
        public double Fuel;
        public int Milinage;

        public Car()
        {
            Fuel = 50;
            Milinage = 0;
        }
        public void Move()
        {
            Milinage++;
            Fuel -= 0.5;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }

    }
    enum TypeCar
    {
        Gas = 0,
        Electricity
    }
    class HybridCar : Car
    {
        public TypeCar TypeCar;

        public void ChangeTypeCar(TypeCar type)
        {
            TypeCar = type;
        }
    }

}