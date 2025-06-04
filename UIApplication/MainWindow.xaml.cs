using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UIApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Expense> expenses = new();
        string saveFileName = "notes.json";
        public MainWindow()
        {
            InitializeComponent();
            ExpenseListBox.ItemsSource = expenses;
        }

        private void AddExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            AddExpenseWindow addExpenseWindow = new AddExpenseWindow(this);
            if (addExpenseWindow.ShowDialog() == true)
            {
                try
                {
                    expenses.Add(addExpenseWindow.Expense);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
            private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists(saveFileName))
            {
                string jsonContent = File.ReadAllText(saveFileName);
                expenses = JsonSerializer.Deserialize<ObservableCollection<Expense>>(jsonContent);
                ExpenseListBox.ItemsSource = expenses;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string jsoncontent = JsonSerializer.Serialize(expenses, options);
            try
            {
                File.WriteAllText(saveFileName, jsoncontent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно выполнить сохранение\n" + ex.Message);
            }

        }



        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            var note = ExpenseListBox.SelectedItem as Expense;
            if (note != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Title = "Экспорт",
                    FileName = note.Title,
                    DefaultExt = ".txt",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, note.Content);
                }
            }
        }
    }
}