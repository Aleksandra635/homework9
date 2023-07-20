// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int a = Prompt("Введите минимальное число: ");
int b = Prompt("Введите максимальное число: ");
Console.WriteLine($"{Recursy(b, a)}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Recursy (int b, int a)
{
    if (b < a)
    {
    return 0;
    }
    return Recursy(b-1, a) + b;
}