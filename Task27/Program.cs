// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {number} = {SumNumbers(number)}");
int SumNumbers(int number)
{
    int length = Convert.ToString(number).Length;;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
