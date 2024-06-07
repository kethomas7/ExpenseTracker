namespace ExpenseTracker.Services
{
    public class MenuService
    {
        public static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;//colors text a certain color
                Console.WriteLine("Expense Tracker 3000");
                Console.ResetColor();// sets it back to default color

                Console.WriteLine("\nOption 1: Add an expense");
                Console.WriteLine("Option 2: Monthly expense report");
                Console.WriteLine("Option 3: Budget/Expense Comparison");
                Console.WriteLine("Option 4: Exit");
                Console.WriteLine("\nEnter 1, 2, 3, or 4 to navigate");

                string optionSelected = Console.ReadLine();



                switch (optionSelected)
                {
                    case "1":

                        Console.WriteLine("Would you like to add another expense? Yes or No");
                        string answer = Console.ReadLine().ToLower();

                        if (answer == "yes")
                        {
                            ExpenseService.AddExpense();
                        }
                        else
                        {
                            ExpenseService.ExpenseSummaryCheck();

                        }

                        break;
                    case "2":

                        Console.WriteLine("What month would you like to view?");
                        string nameOfMonth = Console.ReadLine();
                        Console.Clear();
                        int numberOfMonth = MonthConverter(nameOfMonth);
                        ExpenseService.MonthlyExpenseReport(numberOfMonth);

                        break;
                    case "3":


                        Console.WriteLine("\nEnter the month you would like to compare the budget and expenses");
                        string nameOfBudgetMonth = Console.ReadLine();

                        Console.WriteLine($"\nWhat was your budget for the month of {nameOfBudgetMonth}");
                        decimal budget = decimal.Parse(Console.ReadLine());

                        Console.Clear();

                        int numberOfBudgetMonth = MonthConverter(nameOfBudgetMonth);
                        decimal total = ExpenseService.MonthlyExpenseReport(numberOfBudgetMonth);

                        MonthlyBudgetComparison(budget, total);

                        break;
                    case "4":
                        Console.WriteLine("\nExiting application!");

                        return;

                    default:
                        Console.WriteLine("\nPlease enter 1, 2, 3, 4, to navigate");
                        optionSelected = Console.ReadLine();
                        break;
                }

            }
        }
    }
}
