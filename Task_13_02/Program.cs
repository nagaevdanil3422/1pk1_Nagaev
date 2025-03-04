using static Task_13_02.Animal;

namespace Task_13_02
{
    internal class Program
    {
        static void Main()
        {
  
         Animals myPet = new Animals("Барсик", "Кот", 3, 4.5, true);
         myPet.DisplayInfo();

         myPet.ChangeWeight(5.0);
         myPet.ChangeHealthStatus(false);

         myPet.DisplayInfo();
            


        }
    }
}
