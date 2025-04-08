using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_03
{
    //  Класс пациента
    [Serializable]
    public class Patient
    {
        public PatientStatus Status { get; set; } //статус
        public DateTime AdmissionDate { get; set; } //дата поступления
        public DateTime? DischargeDate { get; set; } // Дата выписки ( На начало пустая )
        public string Complaints { get; set; } // Жалобы
        public string Diagnosis { get; set; } // Диагноз
        public string Treatment { get; set; } // Лечение

        public Patient(PatientStatus status, DateTime admissionDate, string complaints, string diagnosis, string treatment)
        {
            Status = status;
            AdmissionDate = admissionDate;
            Complaints = complaints;
            Diagnosis = diagnosis;
            Treatment = treatment;
            DischargeDate = null; // Изначально дата выписки пустая
        }
    }
}

