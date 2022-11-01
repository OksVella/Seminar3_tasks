// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Write("Enter a number: ");
string num = Console.ReadLine();

if (num.Length == 5)
{
    checkingNumber(num);
}
else 
{
    Console.WriteLine($"Enter correct number");
}


// -----------Methods-----------

void checkingNumber(string num)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"Your number: {num} - palindrome.");
    }
    else
    {
        Console.WriteLine($"Your number: {num} - not palindrome.");
    }
}