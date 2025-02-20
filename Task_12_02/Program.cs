namespace Task_12_02
{
    internal class Program
    {
        static void Main()
        {
            Animals animal = new Animals();
            string namecat = animal.nameCat;
            int agecat = animal.ageCat;
            string ishappycat = animal.IsHappyCat;

            animal.nameCat = "Barsik";
            animal.ageCat = 2;
            animal.IsHappyCat = "Счастлив";


            string namedog = animal.nameDog;
            int agedog = animal.ageDog;
            string ishappydog = animal.IsHappyDog;

            animal.nameDog = "Bobik";
            animal.ageDog = 4;
            animal.IsHappyDog = "Не счастлив";

            animal.InfoCat();
            Console.WriteLine();
            animal.InfoDog();


        }
    }
}
