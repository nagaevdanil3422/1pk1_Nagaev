namespace Task_13_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car myCar1 = new Car();
            myCar1.DisplayInfo();


            Car myCar2 = new Car("A123BC", "Toyota", "Красный");
            myCar2.DisplayInfo();


            myCar2.Accelerate(50);
            myCar2.Accelerate(160);
            myCar2.Brake();

            myCar2.DisplayInfo();
        }
    }
}

