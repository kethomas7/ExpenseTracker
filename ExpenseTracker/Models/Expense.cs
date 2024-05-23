using ExpenseTracker.Interfaces;

namespace ExpenseTracker.Models
{
    public class Expense : IExpense
    {
        public string ExpenseName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string ExpenseCategory { get; set; } = string.Empty;

        public Expense() { }

    }
}
