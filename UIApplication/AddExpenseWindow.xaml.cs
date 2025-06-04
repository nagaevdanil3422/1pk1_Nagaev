using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UIApplication

{
    public enum CategoryExpense
    {
        buyingFood,
        paymentForHousing,
        paymentForTransportationToAndFromWork,
        buyingClothes
    }
    /// <summary>
    /// Логика взаимодействия для AddExpenseWindow.xaml
    /// </summary>
    public partial class AddExpenseWindow : Window
    {

        public Expense Expense
        {
            get
            {
                if (!string.IsNullOrEmpty(TitleTextBox.Text))
                {
                    decimal amount;
                    if (!decimal.TryParse(AmountTextBox.Text, out amount))
                    {
                        throw new Exception("Сумма должна быть числом");
                    }

                    // Приведение типа без использования 'as'
                    var selectedItem = (CategoryExpense)CategoryComboBox.SelectedItem;

                    if (selectedItem == null)
                    {
                        throw new Exception("Не выбрана категория");
                    }

                    return new Expense(DateTime.Now, amount, selectedItem, TitleTextBox.Text, ContentTextBox.Text);
                }
                else
                {
                    throw new Exception("Заголовок не может быть пустым");
                }
            }
        }

        public AddExpenseWindow(Window owner)
        {
            this.Owner = owner;
            InitializeComponent();
            LoadCategories(); // Загрузить категории при создании окна
        }

        public AddExpenseWindow(Window owner, Expense expense) : this(owner)
        {
            TitleTextBox.Text = expense.Title;
            ContentTextBox.Text = expense.Content;
            AmountTextBox.Text = expense.Amount.ToString();
            CategoryComboBox.SelectedItem = expense.Category;
        }

        private void LoadCategories()
        {
            // Здесь вы можете добавить категории в ComboBox
            CategoryComboBox.Items.Add(new CategoryExpense());
            CategoryComboBox.Items.Add(new CategoryExpense());
            CategoryComboBox.Items.Add(new CategoryExpense());
            // Добавьте другие категории по необходимости
        }

        private void AddExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Проверяем корректность данных перед закрытием окна
                var expense = Expense; // Это вызовет исключение, если данные некорректны
                this.DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
