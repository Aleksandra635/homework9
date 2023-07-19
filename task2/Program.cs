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