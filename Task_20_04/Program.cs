namespace Task_20_04
{
    /*  Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
        • Car
        • Bike
        • Bus
        • Truck
        • Motorcycle
        Храните список транспортных средств (можно просто List<VehicleType>).
        Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков).
        Реализуйте поиск по типу и вывод информации
    */
    internal class Program
    {
        
        enum VehicleType
        {
            Car,
            Bike,
            Bus,
            Truck,
            Motorcycle
        }

        static List<VehicleType> vehicles = new List<VehicleType>();

        static void Main()
        {
            
            vehicles.Add(VehicleType.Car);
            vehicles.Add(VehicleType.Truck);
            vehicles.Add(VehicleType.Bike);
            vehicles.Add(VehicleType.Truck);
            vehicles.Add(VehicleType.Motorcycle);

            
            int truckCount = CountVehicles(VehicleType.Truck);
            Console.WriteLine($"Количество грузовиков: {truckCount}");

            
            DisplayVehicles(VehicleType.Car);
        }

        static int CountVehicles(VehicleType type)
        {
            return vehicles.Count(v => v == type);
        }

        static void DisplayVehicles(VehicleType type)
        {
            var foundVehicles = vehicles.Where(v => v == type).ToList();

            if (foundVehicles.Count > 0)
            {
                Console.WriteLine($"Найдены следующие транспортные средства типа {type}:");
                foreach (var vehicle in foundVehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine($"Транспортные средства типа {type} не найдены.");
            }
        }
    }
}

