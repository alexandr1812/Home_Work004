Console.WriteLine("Привествую дорогой пользователь");
Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

int ExponentiationNumberB(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}

int num = ExponentiationNumberB(numA, numB);
Console.WriteLine($"Answer: {num}"); 