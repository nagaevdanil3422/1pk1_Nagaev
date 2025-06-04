using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIApplication
{
    public class Expense : IComparable
    {
        public DateTime Date { get; }
        public decimal Amount { get; }
        public CategoryExpense Category { get; }
        public string Title { get; }
        public string Content { get; }

        public Expense(DateTime date, decimal amount, CategoryExpense category, string title, string content)
        {
            Date = date;
            Amount = amount;
            Category = category;
            Title = title;
            Content = content;
        }
        public override string ToString()
        {
            return $"{Title} - {Date} - {Amount} - {Category}";
        }
        public string StringCategory()
        {
            switch (Category)
            {
                case CategoryExpense.buyingFood: return "покупка продуктов питания"; break;
                case CategoryExpense.paymentForHousing: return "оплата жилья"; break;
                case CategoryExpense.paymentForTransportationToAndFromWork: return "оплата транспорта для проезда на работу и обратно"; break;
                case CategoryExpense.buyingClothes: return "покупка одежды"; break;
            }
            return null;
        }
        public int CompareTo(Object? obj)
        {
            if (obj == null && obj is Expense expense)
            {
                return (Category).CompareTo(expense.Category);
            }
            else
                throw new ArgumentException();
        }
    }
}
