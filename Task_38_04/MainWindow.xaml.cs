using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_38_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private BazaData _bazaData = new();
        public MainWindow()
        {
            InitializeComponent();
            polComboBox.SelectedIndex = 1;
            dataListBox.ItemsSource = _bazaData.Students;

        }
        private bool Validate(out string error)
        {
            error = " ";
            try
            {
                int year = Convert.ToInt32(dateBirthday.Text);
                if (year < 1900 || year > DateTime.Now.Year)
                {
                    error += "год рождения должен быть от 1900 до текущего года\n";
                }
            }
            catch (FormatException ex)
            {
                error += "год рождения - число";
            }
            if (string.IsNullOrEmpty(secondNameTextBox.Text))
            {
                error += "Строка пустая";
            }
            else if (string.IsNullOrEmpty(firstNameTextBox.Text)) 
            {
                error += "Строка пустая";
            }
                
            else if (string.IsNullOrEmpty(middleNameTextBox.Text))
            {
                error += "Строка пустая";
            }
            else if (string.IsNullOrEmpty(groupTextBox.Text))
            {
                error += "Строка пустая";
            }
            if (error.Length > 0)
            {
                return false;
            }
            return true;
        }
        private void saveDataButton_Click(object sender, EventArgs e)
        {
            if (Validate(out string errorMesagge))
            {
                MessageBox.Show(errorMesagge);
                return;
            }
            BazaData bazaData = new BazaData(
                secondNameTextBox.Text,
                firstNameTextBox.Text,
                middleNameTextBox.Text,
                groupTextBox.Text,
                (StatusPol)polComboBox.SelectedIndex,
                Int32.Parse(dateBirthday.Text));

            _bazaData.SaveStudents();
            dataListBox.Items.Refresh();

        }
    }
}
