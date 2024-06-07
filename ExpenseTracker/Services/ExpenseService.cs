using ExpenseTracker.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ExpenseTracker.Services
{
    public  class ExpenseService
    {
        List<Expense> expenseList = new List<Expense>();     //need to ask 

       public static void AddExpense()
        {
 

            Console.WriteLine("\nEnter the information regarding your expense:\nExpense Amount:");
            decimal amount = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nExpense Category:");
            string category = Console.ReadLine();
            Console.WriteLine("\nExpense Name:");
            string name = Console.ReadLine();
            Console.WriteLine("\nExpense Date:");
            DateTime date = DateTime.Parse(Console.ReadLine());


            Expense Expense = new Expense()
            {
                Amount = amount,
                ExpenseCategory = category,
                ExpenseName = name,
                Date = date
            };
            expenseList.Add(Expense);

            ExpenseSummaryCheck();

        }

      public static void ExpenseSummaryCheck()
        {
            Console.WriteLine("\nWould you like to view a summary of your expenses? Yes or No");
            string answer = Console.ReadLine();

            if (answer == "yes".ToLower())
            {
                Console.WriteLine("\nExpense Summary");
                foreach (var item in expenseList)
                {
                    Console.WriteLine($"\nExpense Name: {item.ExpenseName} | Expense Cateorgy: {item.ExpenseCategory} | Date: {item.Date} | Amount: {item.Amount}");
                }
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

        }

        public static decimal MonthlyExpenseReport(int monthNumber)
        {
            decimal total = 0;
            var monthlyExpenses = expenseList.Where(expense => expense.Date.Month == monthNumber).OrderBy(expense => expense.Date).ToList();


            foreach (var expense in monthlyExpenses)
            {

                Console.WriteLine($"\nExpense Name: {expense.ExpenseName} | Expense Cateorgy: {expense.ExpenseCategory} | Date: {expense.Date} | Amount: ${expense.Amount}");

                total += expense.Amount;


            }

            Console.WriteLine($"\nTotal expenses: ${total}");

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

            return total;


        }


    }
}
