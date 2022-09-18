Console.WriteLine("Введите два целых числа для того, чтобы узнать является ли первое число квадратом второго");
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int square = numberB * numberB;
if (square == numberA)
{
    Console.WriteLine($"Первое число {numberA} является кваратом второго числа {numberB}");
}
else
{
    Console.WriteLine($"Первое число {numberA} не является кваратом второго числа {numberB}");
}