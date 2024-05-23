using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public static class ApplicationService
    {
        public static void Start()
        {
            var test1 = new Expense()
            {
                ExpenseName = "Walmart",
                ExpenseCategory = "Shopping",
                Amount = 589.65m,
                Date = DateTime.Parse("10/10/2023")
            };
            var test2 = new Expense()
            {
                ExpenseName = "Hush",
                ExpenseCategory = "Fun",
                Amount = 89.65m,
                Date = DateTime.Parse("05/16/2023")

            };

            var test6 = new Expense()
            {
                ExpenseName = "Target",
                ExpenseCategory = "Shopping",
                Amount = 29.65m,
                Date = DateTime.Parse("9/10/2023")
            };
            var test7 = new Expense()
            {
                ExpenseName = "Beauty supply",
                ExpenseCategory = "Hair",
                Amount = 389.65m,
                Date = DateTime.Parse("09/29/2023")
            };

            var test3 = new Expense()
            {
                ExpenseName = "GasStation",
                ExpenseCategory = "Gas",
                Amount = 100.50m,
                Date = DateTime.Parse("05/05/2023")
            };
            var test4 = new Expense()
            {
                ExpenseName = "Burger King",
                ExpenseCategory = "Food",
                Amount = 5.65m,
                Date = DateTime.Parse("09/16/2023")
            };
            var test5 = new Expense()
            {
                ExpenseName = "Long Horn",
                ExpenseCategory = "Food",
                Amount = 200.95m,
                Date = DateTime.Parse("05/23/2023")
            };

            var ExpenseList = new List<Expense>() { test1, test2, test3, test4, test5, test6, test7 };

            MainMenu();

            void MainMenu()
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
                            // AddExpense();
                            Console.WriteLine("Would you like to add another expense? Yes or No");
                            string answer = Console.ReadLine().ToLower();

                            if (answer == "yes")
                            {
                                AddExpense();
                            }
                            else
                            {
                                ExpenseSummaryCheck();

                            }

                            break;
                        case "2":

                            Console.WriteLine("What month would you like to view?");
                            string nameOfMonth = Console.ReadLine();
                            Console.Clear();
                            int numberOfMonth = MonthConverter(nameOfMonth);
                            MonthlyExpenseReport(numberOfMonth);

                            break;
                        case "3":


                            Console.WriteLine("\nEnter the month you would like to compare the budget and expenses");
                            string nameOfBudgetMonth = Console.ReadLine();

                            Console.WriteLine($"\nWhat was your budget for the month of {nameOfBudgetMonth}");
                            decimal budget = decimal.Parse(Console.ReadLine());

                            Console.Clear();

                            int numberOfBudgetMonth = MonthConverter(nameOfBudgetMonth);
                            decimal total = MonthlyExpenseReport(numberOfBudgetMonth);

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

                //   MainMenu();
            }









            void AddExpense()
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
                ExpenseList.Add(Expense);

                ExpenseSummaryCheck();

            }

            void ExpenseSummaryCheck()
            {
                Console.WriteLine("\nWould you like to view a summary of your expenses? Yes or No");
                string answer = Console.ReadLine();

                if (answer == "yes".ToLower())
                {
                    Console.WriteLine("\nExpense Summary");
                    foreach (var item in ExpenseList)
                    {
                        Console.WriteLine($"\nExpense Name: {item.ExpenseName} | Expense Cateorgy: {item.ExpenseCategory} | Date: {item.Date} | Amount: {item.Amount}");
                    }
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();

            }

            decimal MonthlyExpenseReport(int monthNumber)
            {
                decimal total = 0;
                var monthlyExpenses = ExpenseList.Where(expense => expense.Date.Month == monthNumber).OrderBy(expense => expense.Date).ToList();


                foreach (var expense in monthlyExpenses)
                {

                    Console.WriteLine($"\nExpense Name: {expense.ExpenseName} | Expense Cateorgy: {expense.ExpenseCategory} | Date: {expense.Date} | Amount: ${expense.Amount}");

                    total += expense.Amount;//adds up the total amount of expeinces in this list


                }

                Console.WriteLine($"\nTotal expenses: ${total}");

                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();

                return total;


            }
            void MonthlyBudgetComparison(decimal budget, decimal totalExpenses)
            {
                Console.WriteLine($"\nBudget total at beginning of month: ${budget}");
                decimal newBudget = budget - totalExpenses;
                Console.WriteLine($"Budget total at the end of the month: ${newBudget}");



                decimal percentDecrease = (((budget - newBudget) / budget) * 100);

                Console.WriteLine($"Percent decrease:{Decimal.Round(percentDecrease)}%");

                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
            }
            int MonthConverter(string month)
            {


                switch (month.ToLower())
                {
                    case "january":
                        Console.WriteLine("\nHere are your January expenses:");
                        return 1;

                    case "february":
                        Console.WriteLine("\nHere are your February expenses:");
                        return 2;
                    case "march":
                        Console.WriteLine("\nHere are your March expenses:");
                        return 3;
                    case "april":
                        Console.WriteLine("\nHere are your April expenses:");
                        return 4;
                    case "may":
                        Console.WriteLine("\nHere are your May expenses:");
                        return 5;
                    case "june":
                        Console.WriteLine("\nHere are your June expenses:");
                        return 6;
                    case "july":
                        Console.WriteLine("\nHere are your July expenses:");
                        return 7;
                    case "august":
                        Console.WriteLine("\nHere are your August expenses:");
                        return 8;
                    case "september":
                        Console.WriteLine("\nHere are your September expenses:");
                        return 9;
                    case "october":
                        Console.WriteLine("\nHere are your October expenses:");
                        return 10;
                    case "november":
                        Console.WriteLine("\nHere are your November expenses:");
                        return 11;
                    case "december":
                        Console.WriteLine("\nHere are your December expenses:");
                        return 12;
                    default: return 0;




                }



            }



        }
        public static void Stop()
        {

        }
    }
}
