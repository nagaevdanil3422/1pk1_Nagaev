using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_04
{
    public enum StatusPol
    {
        men,
        women
    }
    [Serializable]
    public class RegistrationStudent
    {
        public string SecondNameTextBox { get; set; }
        public string FirstNameTextBox { get; set; }
        public string MiddleNameTextBox { get; set; }
        public StatusPol Pol { get; set; }
        public int DateBirthday { get; set; }

        public RegistrationStudent(string secondNameTextBox, string firstNameTextBox, string middleNameTextBox, StatusPol pol, int dateBirthday)
        {
            SecondNameTextBox = secondNameTextBox;
            FirstNameTextBox = firstNameTextBox;
            MiddleNameTextBox = middleNameTextBox;
            Pol = pol;
            DateBirthday = dateBirthday;
        }
        public override string ToString()
        {
            return $"{SecondNameTextBox} {FirstNameTextBox} {MiddleNameTextBox}";
        }
        public string StringStatus()
        {
            switch (Pol)
            {
                case StatusPol.men: return "Мужской"; break;               
                case StatusPol.women: return "Женский"; break;
            }
            return null;

        }
    }
}
