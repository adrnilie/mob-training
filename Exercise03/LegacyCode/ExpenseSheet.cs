﻿namespace PrincipalIT.LegacyCode;

public enum ExpenseType {
    Dinner, 
    Breakfast, 
    CarRental
}

public class Expense {
    public ExpenseType type;
    public int amount;
}

public class ExpenseSheet
{
    public void Print(IEnumerable<Expense> expenses) {
        int total = 0;
        int mealExpenses = 0;

        Console.WriteLine("Expenses " + DateTime.Now);

        foreach (Expense expense in expenses) {
            if (expense.type == ExpenseType.Dinner || expense.type == ExpenseType.Breakfast) {
                mealExpenses += expense.amount;
            }

            String expenseName = "";
            switch (expense.type) {
                case ExpenseType.Dinner:
                    expenseName = "Dinner";
                    break;
                case ExpenseType.Breakfast:
                    expenseName = "Breakfast";
                    break;
                case ExpenseType.CarRental:
                    expenseName = "Car Rental";
                    break;
            }

            String mealOverExpensesMarker = expense.type == ExpenseType.Dinner && expense.amount > 5000 || expense.type == ExpenseType.Breakfast && expense.amount > 1000 ? "X" : " ";

            Console.WriteLine(expenseName + "\t" + expense.amount + "\t" + mealOverExpensesMarker);

            total += expense.amount;
        }

        Console.WriteLine("Meal expenses: " + mealExpenses);
        Console.WriteLine("Total expenses: " + total);
    }
}