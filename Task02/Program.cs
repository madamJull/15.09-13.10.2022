Console.WriteLine("Ведите два числа, чтобы узнать какое из них большее, а какое меньшее");
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"Первое число {numberA} является максимальным, второе число {numberB} является минимальным");
}
else
{
    Console.WriteLine($"Второе число {numberB} является максимальным, первое число {numberA} является минимальным");
}