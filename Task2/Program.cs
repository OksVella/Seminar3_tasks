// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int randomValue = new Random().Next(2, 10);
Console.WriteLine("Random value = " + randomValue);

for (int i = 1; i <= randomValue; i++)
{
    Console.Write(i * i * i);
    if (i < randomValue)
    {
        Console.Write(", ");
    }
}




