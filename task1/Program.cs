
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