﻿WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine(); // or use "49" in a notebook
try
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old.");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing");

// Catching with filters
Write("Enter an amount: ");
string amount = ReadLine()!;
if (string.IsNullOrEmpty(amount)) return;
try
{
    decimal amountValue = decimal.Parse(amount);
    WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!");
}