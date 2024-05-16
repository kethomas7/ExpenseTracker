

using ExpenseTracker;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

//Console.ForegroundColor = ConsoleColor.Magenta;//colors text a certain color
//Console.WriteLine("Welcome to Expense Tracker 3000");
//Console.ResetColor();// sets it back to default color

//Console.WriteLine("\nUse the ⬆️ and ⬇️ arrows to navigate and press the \u001b[32mEnter\u001b[0m key to select");

//ConsoleKeyInfo key;
// bool isSelected = false;

//while (!isSelected)
//{
//    Console.WriteLine("    \u001b[32mAdd an expense\u001b[0m");
//    Console.WriteLine("    See monthly expense report");
//    Console.WriteLine("    Comparsion");

//    key = Console.ReadKey(true);

//}
//var ExpenseList = new List<Expense>();

var test1 = new Expense()
{
    ExpenseName = "Walmart",
    ExpenseCategory = "Shopping",
    Amount = 589.65m,
    Date = DateTime.Parse("10/10/2019")
};
var test2 = new Expense()
{
    ExpenseName = "Hush",
    ExpenseCategory = "Fun",
    Amount = 89.65m,
    Date = DateTime.Parse("05/16/2023")
};
var test3 = new Expense()
{
    ExpenseName = "Long Horn",
    ExpenseCategory = "Food",
    Amount = 200.95m,
    Date = DateTime.Parse("03/23/2017")
};

var ExpenseList = new List<Expense>() {test1, test2, test3};

void MainMenu()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;//colors text a certain color
    Console.WriteLine("Expense Tracker 3000");
    Console.ResetColor();// sets it back to default color

    Console.WriteLine("\nOption 1: Add an expense");
    Console.WriteLine("Option 2: See monthly expense report");
    Console.WriteLine("Option 3: Comparsion");
    Console.WriteLine("Option 4: Exit");
    Console.WriteLine("\nEnter 1, 2, 3, or 4 to navigate");

   string optionSelected = Console.ReadLine();
    switch (optionSelected)
    {
        case "1":
           // AddExpense();
          Console.WriteLine("Would you like to add another expense? Yes or No");
          string answer = Console.ReadLine().ToLower();

            if(answer == "yes")
            {
            // AddExpense();
            }
            else
            {
            ExpenseSummaryCheck();
              
            }
          
            break; 
        case "2":
            MonthlyExpenseReport();
            break;
        case "3":
            break;
        case "4":
            break;
    }
   // MainMenu();
}

MainMenu();


//void AddExpense()
//{
//    Console.WriteLine("\nEnter the information regarding your expense:\nExpense Amount:");
//    decimal amount = Decimal.Parse(Console.ReadLine());
//    Console.WriteLine("\nExpense Category:");
//    string category = Console.ReadLine();
//    Console.WriteLine("\nExpense Name:");
//    string name = Console.ReadLine();
//    Console.WriteLine("\nExpense Date:");
//    DateTime date = DateTime.Parse(Console.ReadLine());


//    Expense Expense = new Expense(name, amount, date, category)
//    {
//        Amount = amount,
//        ExpenseCategory = category,
//        ExpenseName = name,
//        Date = date
//    };
//    ExpenseList.Add(Expense);

//    ExpenseSummaryCheck();

//}

void ExpenseSummaryCheck()
{
    Console.WriteLine("\nWould you like to view a summary of your expenses? Yes or No");
    string answer = Console.ReadLine();
    if (answer == "yes".ToLower())
    {
        foreach (var item in ExpenseList)
        {
            Console.WriteLine($"\nExpense List Summary\n\nExpense Name: {item.ExpenseName} | Expense Cateorgy: {item.ExpenseCategory} | Date: {item.Date} | Amount: {item.Amount}");
        }
    }
    else 
    {
        MainMenu();
    }
}

void MonthlyExpenseReport()
{
    var monthlyExpenses = ExpenseList.OrderBy(expense => expense.Date).ThenBy(expense => expense.Amount).ToList();

    foreach(var expense in monthlyExpenses)
    {
        Console.WriteLine($"\nExpense List Summary\n\nExpense Name: {expense.ExpenseName} | Expense Cateorgy: {expense.ExpenseCategory} | Date: {expense.Date} | Amount: {expense.Amount}");
    }
    
}//ask how will i get to say each month then list it out

//for step 3 use switch statement for months

//void exit()
//{

//}


