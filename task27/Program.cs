Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int numberA)
{
    int result = 0;
    int SumPlus = 0;
    int Plus = Convert.ToString(numberA).Length;

    for (int i = 0; i < Plus; i++)
    {
        SumPlus = numberA - numberA % 10;
        result = result + (numberA - SumPlus);
        numberA = numberA / 10;
    }
    return result;
}
int additionNumbers = SumNumbers(numberA);
Console.WriteLine($"Answer -> {additionNumbers}");
