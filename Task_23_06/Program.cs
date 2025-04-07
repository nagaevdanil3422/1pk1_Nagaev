namespace Task_23_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayDrives();
            DisplayUserFolders();
            string workPath = @"D:work";
            CreateDirectory(workPath);
            string tempPath = Path.Combine(workPath, "temp");
            CreateDirectory(tempPath);
            DisplayDirectoryInfo(workPath);
            DisplayDirectoryInfo(tempPath);
            string newTempPath = Path.Combine(workPath, "newTemp");
            MoveDirectory(tempPath, newTempPath);
            DeleteDirectory(newTempPath);
        }

        static void DisplayDrives()
        {
            Console.WriteLine("Доступные диски:");
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                Console.WriteLine($"Диск: {drive.Name}, Тип: {drive.DriveType}, Свободное место: {drive.AvailableFreeSpace / (1024 * 1024)} MB");

            }
        }
        static void DisplayUserFolders()
        {
            string userFolderPath = @"C:Users";
            Console.WriteLine("\nСодержимое каталога " + @"C:\Users:");
            if (Directory.Exists(userFolderPath))
            {
                foreach (var dir in Directory.GetDirectories(userFolderPath))
                {
                    Console.WriteLine(Path.GetFileName(dir));
                }
            }
            else
            {
                Console.WriteLine("Каталог не найден.");
            }

        }
        static void CreateDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"Каталог '{path}' успешно создан.");
                }
                else
                {
                    Console.WriteLine($"Каталог '{path}' уже существует.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании каталога '{path}': {ex.Message}");
            }
        }

        static void DisplayDirectoryInfo(string path)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                Console.WriteLine($"\nИнформация о каталоге '{path}':");
                Console.WriteLine($"Имя: {dirInfo.Name}");
                Console.WriteLine($"Полный путь: {dirInfo.FullName}");
                Console.WriteLine($"Родительский каталог: {dirInfo.Parent?.FullName}");
                Console.WriteLine($"Дата создания: {dirInfo.CreationTime}");
                Console.WriteLine($"Дата последнего изменения: {dirInfo.LastWriteTime}");
            }
            else
            {
                Console.WriteLine($"Каталог '{path}' не найден.");
            }
        }

        static void MoveDirectory(string sourceDir, string destDir)
        {
            try
            {
                if (Directory.Exists(sourceDir))
                {
                    Directory.Move(sourceDir, destDir);
                    Console.WriteLine($"Каталог '{sourceDir}' успешно перемещен в '{destDir}'.");
                }
                else
                {
                    Console.WriteLine($"Каталог '{sourceDir}' не найден.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при перемещении каталога: {ex.Message}");
            }
        }

        static void DeleteDirectory(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    Console.WriteLine($"Каталог '{path}' успешно удален.");
                }
                else
                {
                    Console.WriteLine($"Каталог '{path}' не найден.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении каталога '{path}': {ex.Message}");
            }
        }
    }
}

