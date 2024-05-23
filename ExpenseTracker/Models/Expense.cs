using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public string ExpenseName { get; set; }
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string ExpenseCategory { get; set; }

        public Expense(string expenseName, decimal amount, DateTime date, string expenseCategory)
        {

        }
        public Expense()
        {


        }
    }
}
