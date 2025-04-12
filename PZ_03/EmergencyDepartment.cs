using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace PZ_03
{
    public static class EmergencyDepartment
    {
        public static List<Patient> patients = new List<Patient>();
        private const string filePath = "patients.json";

        // Метод для загрузки данных из файла
        public static void LoadPatients()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    patients = JsonSerializer.Deserialize<List<Patient>>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
                }
            }
        }
        // Метод для сохраннеия данных в файл
        public static void SavePatients()
        {
            try
            {
                string json = JsonSerializer.Serialize(patients);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
        // Метод для добавления нового пациента
        public static void AddPatient(PatientStatus status, DateTime admissionDate, string complaints, string diagnosis, string treatment)
        {
            var newPatient = new Patient(status, admissionDate, complaints, diagnosis, treatment);
            patients.Add(newPatient);
            SavePatients();
        }
        // Метод изменения состояния пациента
        public static void ChangePatientStatus(int patientIndex, PatientStatus newStatus)
        {
            if (patientIndex >= 0 && patientIndex < patients.Count)
            {
                patients[patientIndex].Status = newStatus;
                SavePatients();
            }
            else
                Console.WriteLine("Пациент не найден");
        }
        // Метод выписки пациента
        public static void DischargePatient(int patientIndex, DateTime? dischargeDate)
        {
            if (patientIndex >= 0 && patientIndex < patients.Count)
            {
                patients[patientIndex].DischargeDate = dischargeDate;
                SavePatients();
            }
            else
                Console.WriteLine("Пациент не найден");
        }
        //  Метод вывода всех пациентов отделения
        public static void ListAllPatients()
        {
            Console.WriteLine("-----Все пациенты-----");
            foreach (var patient in patients)
            {
                Console.WriteLine($"Статус: {patient.Status}, Дата поступления: {patient.AdmissionDate}, Дата выписки: {patient.DischargeDate}, Жалобы: {patient.Complaints}, Диагноз: {patient.Diagnosis}, Назначенное лечение: {patient.Treatment}");
            }
        }
        // Вывод пациентов отделения по тяжести состояния
        public static void ListPatientsByStatus(PatientStatus status)
        {
            Console.WriteLine($"Пациенты с соcтоянием: {status}");
            foreach (var patient in patients.Where(p => p.Status == status))
            {
                Console.ForegroundColor = GetColorByStatus(status);
                Console.WriteLine($"Статус: {patient.Status}, Дата поступления: {patient.AdmissionDate}, Дата выписки: {patient.DischargeDate}, Жалобы: {patient.Complaints}, Диагноз: {patient.Diagnosis}, Назначенное лечение: {patient.Treatment}");
                Console.ResetColor();
            }
        }
        private static ConsoleColor GetColorByStatus(PatientStatus status)
        {
            return status switch
            {
                PatientStatus.Satisfactory => ConsoleColor.Green,
                PatientStatus.Moderate => ConsoleColor.Yellow,
                PatientStatus.Severe => ConsoleColor.Red,
                _ => ConsoleColor.White,
            };


        }
        // Вывод пациентов, поступивших на конкретную дату  
        public static void ListPatientsByAdmissionDate(DateTime date)
        {
            Console.WriteLine($"-----Пациенты поступившие {date.ToShortDateString}-----");
            foreach (var patient in patients.Where(p => p.AdmissionDate.Date == date.Date))
            {
                Console.WriteLine($"Статус: {patient.Status}, Дата поступления: {patient.AdmissionDate}, Дата выписки: {patient.DischargeDate}, Жалобы: {patient.Complaints}, Диагноз: {patient.Diagnosis}, Назначенное лечение: {patient.Treatment}");
            }
        }
        // Вывод пациентов, выписанных из отделения
        public static void ListDischargedPatients()
        {
            Console.WriteLine("-----Выписанные пациенты-----");
            foreach (var patient in patients.Where(p => p.DischargeDate.HasValue))
            {
                Console.WriteLine($"Статус: {patient.Status}, Дата поступления: {patient.AdmissionDate}, Дата выписки: {patient.DischargeDate}, Жалобы: {patient.Complaints}, Диагноз: {patient.Diagnosis}, Назначенное лечение: {patient.Treatment}");
            }
        }
        // Метод-генератор для заполнения списка пациентов
        public static void GeneratePatients(int count)
        {
            Random random = new Random();
            var statuses = Enum.GetValues(typeof(PatientStatus)).Cast<PatientStatus>().ToArray();
            var complaintsList = new[] { "Головная боль", "Температура", "Кашель", "Боль в животе" };
            var diagnosisList = new[] { "Грипп", "Острый аппендицит", "Бронхит", "Пневмония" };
            var treatmentList = new[] { "Покой и обильное питьё", "Хирургическое вмешательство", "Антибиотики", "Противовирусные препараты" };

            for (int i = 0; i < count; i++)
            {
                var status = statuses[random.Next(statuses.Length)];
                var admissionDate = DateTime.Now.AddDays(-random.Next(1, 10)); // Случайная дата поступления за последние 10 дней
                var complaints = complaintsList[random.Next(complaintsList.Length)];
                var diagnosis = diagnosisList[random.Next(diagnosisList.Length)];
                var treatment = treatmentList[random.Next(treatmentList.Length)];

                AddPatient(status, admissionDate, complaints, diagnosis, treatment);
            }
        }
        
        
    }
}
