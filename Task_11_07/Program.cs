namespace Task_11_07
{   /*  Передача массива по ссылке (ref): Напишите метод, который принимает массив целых чисел по
        ссылке и изменяет его элементы, увеличивая каждый на 1.
        Проверьте, изменился ли оригинальный массив вне метода
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 5, 6 };
            Console.WriteLine("Оригинальный список: " + string.Join(", ", array));
            ModifiArray(ref array);
            Console.WriteLine("Измененый список: " + string.Join(", ", array));

        }
        public static void ModifiArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 1;
            }
        }
    }
}
