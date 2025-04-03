namespace Task_20_06
{
    enum TrafficLightColor
    {
        Red,
        Yellow,
        Green
    }

    class Program
    {
        static TrafficLightColor currentColor = TrafficLightColor.Red;
        static bool running = true;

        static void Main()
        {
            
            Thread trafficLightThread = new Thread(SwitchTrafficLight);
            trafficLightThread.Start();

            Console.WriteLine("Нажмите 'q' для выхода или 'm' для ручного переключения цвета.");

            while (running)
            {
                
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Q)
                    {
                        running = false; 
                    }
                    else if (key == ConsoleKey.M)
                    {
                        ManualSwitch();
                    }
                }
            }

            trafficLightThread.Join(); 
        }

        static void SwitchTrafficLight()
        {
            while (running)
            {
                
                Thread.Sleep(3000); 
                currentColor = GetNextColor(currentColor);
                Console.WriteLine($"Светофор: {currentColor}");
            }
        }

        static TrafficLightColor GetNextColor(TrafficLightColor color)
        {
            return color switch
            {
                TrafficLightColor.Red => TrafficLightColor.Green,
                TrafficLightColor.Green => TrafficLightColor.Yellow,
                TrafficLightColor.Yellow => TrafficLightColor.Red,
                _ => color,
            };
        }

        static void ManualSwitch()
        {
            currentColor = GetNextColor(currentColor);
            Console.WriteLine($"Ручное переключение: {currentColor}");
        }
    }
}
