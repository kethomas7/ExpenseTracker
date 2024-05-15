using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class ExpenseManager:Expense
    {
        public void AddExpense()
        {

            Console.WriteLine("Please enter the information regarding your expense:\n Expense Amount:");
            string amount = Console.ReadLine();
            Console.WriteLine("Expense Category:");
            string category = Console.ReadLine();
            Console.WriteLine("Expense Name:");
           string name= Console.ReadLine();
            Console.WriteLine("Expense Date:");
                 DateTime date = DateTime.Parse(Console.ReadLine());
        

            Expense PowerBill = new Expense()
            {
                Amount = decimal.Parse(amount),
                ExpenseCategory = category,
                ExpenseName = name,
                Date = date

            };

        }
    }
}
