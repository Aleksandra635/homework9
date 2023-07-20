// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int a = Prompt("Введите максимальное число: ");
int b = Prompt("Введите минимальное число: ");
Console.WriteLine($"{Recursy(a, b)}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string Recursy (int a, int b)
{
    if (a == b)
    {
    return b.ToString();
    }
    return Recursy(a-1, b) + "," + a.ToString();
}