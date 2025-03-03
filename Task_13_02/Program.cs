namespace Task_13_02
{
    internal class Program
    {
        static void Main()
        {
            
            Animal Cat = new Animal();
            Console.WriteLine($"1. Информация о животном\n2. Изменить данные веса\n3. Изменить состояние здоровья");
            Console.Write("Введите цифру того что хотите узнать о животном: ");
            string user = Convert.ToString(Console.ReadLine());
            string namecat = Cat.name;
            string vidCat = Cat.vidanimals;
            int ageCat = Cat.age;

            Console.Write("Введите вес котенка: ");
            int Weight = Convert.ToInt32(Console.ReadLine());
            Cat.weight = Weight;
            int weightCat = Cat.weight;

            namecat = "Tom";
            vidCat = "Котенок";
            ageCat = 2;

            Console.Write("Введите здоров ли котенок или нет: ");
            string Health = Convert.ToString(Console.ReadLine());
            Cat.health = Health;
            string healthCat = Cat.health;

            if (user == "1")
            {
                Cat.InfoAnimals();
            }
            else if (user == "2")
            {
                Console.WriteLine(Cat.SetWeight);
            }


            
        }
    }
}
