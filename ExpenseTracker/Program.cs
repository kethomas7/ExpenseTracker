﻿

using System;

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
    Console.WriteLine("\nPlease enter 1, 2, or 3 to navigate");

   string optionSelected = Console.ReadLine();
    switch (optionSelected)
    {
        case "1":
            ExpenseManager.AddExpense();

           break; //expense manager page
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
    }
    MainMenu();
}

MainMenu();

//void exit()
//{

//}


