namespace PZ_03
{
    /*      
            Создать перечисление для состояния пациента (удовлетворительное, средней тяжести, тяжелое)
            Создать класс пациента (состояние, дата поступления, дата выписки (на начало создания объекта пустая), жалобы, диагноз, назначенное лечение)
            Создать список пациентов. Заполнить его программно через специальный метод-генератор


            Создать статичный класс приёмного отделения со статичными методами для:
    1.	Добавления нового пациента
    2.	Изменения состояния пациента
    3.	Выписки пациента
    4.	Вывода всех пациентов отделения
    5.	Вывод пациентов отделения по тяжести состояния (с цветовой идентификацией для разных состояний)
    6.	Вывод пациентов, поступивших на конкретную дату
    7.	Вывод пациентов, выписанных из отделения
    
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            EmergencyDepartment.LoadPatients();

            if (!EmergencyDepartment.patients.Any())
            {
                EmergencyDepartment.GeneratePatients(10);
                Console.WriteLine("Сгенерировано 10 случайных пациентов.");
            }

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("\n--- Приёмное отделение ---");
                Console.WriteLine("1. Вывести всех пациентов");
                Console.WriteLine("2. Вывести пациентов по состоянию");
                Console.WriteLine("3. Вывести пациентов по дате поступления");
                Console.WriteLine("4. Вывести выписанных пациентов");
                Console.WriteLine("5. Добавить нового пациента");
                Console.WriteLine("6. Изменить состояние пациента");
                Console.WriteLine("7. Выписать пациента");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(
                            );
                        EmergencyDepartment.ListAllPatients();
                        break;

                    case "2":
                        Console.Write("Введите состояние пациента (Satisfactory, Moderate, Severe): ");
                        if (Enum.TryParse<PatientStatus>(Console.ReadLine(), out var status))
                        {
                            EmergencyDepartment.ListPatientsByStatus(status);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод состояния.");
                        }
                        break;

                    case "3":
                        Console.Write("Введите дату поступления (yyyy-mm-dd): ");
                        if (DateTime.TryParse(Console.ReadLine(), out var admissionDate))
                        {
                            EmergencyDepartment.ListPatientsByAdmissionDate(admissionDate);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный формат даты.");
                        }
                        break;

                    case "4":
                        EmergencyDepartment.ListDischargedPatients();
                        break;

                    case "5":
                        // Добавление нового пациента
                        Console.Write("Введите состояние пациента (Satisfactory, Moderate, Severe): ");
                        if (Enum.TryParse<PatientStatus>(Console.ReadLine(), out var newPatientStatus))
                        {
                            Console.Write("Введите дату поступления (yyyy-mm-dd): ");
                            DateTime admissionDateInput;
                            while (!DateTime.TryParse(Console.ReadLine(), out admissionDateInput))
                            {
                                Console.Write("Некорректный формат даты. Попробуйте снова: ");
                            }

                            Console.Write("Введите жалобы: ");
                            string complaintsInput = Console.ReadLine();

                            Console.Write("Введите диагноз: ");
                            string diagnosisInput = Console.ReadLine();

                            Console.Write("Введите назначенное лечение: ");
                            string treatmentInput = Console.ReadLine();

                            EmergencyDepartment.AddPatient(newPatientStatus, admissionDateInput, complaintsInput, diagnosisInput, treatmentInput);
                            Console.WriteLine("Пациент успешно добавлен.");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод состояния.");
                        }
                        break;

                    case "6":
                        // Изменение состояния пациента
                        EmergencyDepartment.ListAllPatients();
                        Console.Write("Введите индекс пациента для изменения состояния: ");
                        int indexToChange;
                        while (!int.TryParse(Console.ReadLine(), out indexToChange) || indexToChange < 0 || indexToChange >= EmergencyDepartment.patients.Count)
                        {
                            Console.Write("Некорректный индекс. Попробуйте снова: ");
                        }

                        Console.Write("Введите новое состояние пациента (Satisfactory, Moderate, Severe): ");
                        if (Enum.TryParse<PatientStatus>(Console.ReadLine(), out var changedPatientStatus))
                        {
                            EmergencyDepartment.ChangePatientStatus(indexToChange, changedPatientStatus);
                            Console.WriteLine("Состояние пациента успешно изменено.");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод состояния.");
                        }
                        break;

                    case "7":
                        // Выписка пациента
                        EmergencyDepartment.ListAllPatients();
                        Console.Write("Введите индекс пациента для выписки: ");
                        int indexToDischarge;
                        while (!int.TryParse(Console.ReadLine(), out indexToDischarge) || indexToDischarge < 0 || indexToDischarge >= EmergencyDepartment.patients.Count)
                        {
                            Console.Write("Некорректный индекс. Попробуйте снова: ");
                        }

                        EmergencyDepartment.DischargePatient(indexToDischarge, DateTime.Now);
                        Console.WriteLine("Пациент успешно выписан.");
                        break;

                    case "0":
                        exit = true;
                        break;

                   

                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }

            // Сохранение данных перед выходом из приложения
            EmergencyDepartment.SavePatients();
            Console.WriteLine("Данные сохранены. Выход из приложения.");
        }
    }
}
