// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {CalculateSummOfDigits(m, n)}");
int CalculateSummOfDigits(int m, int n)
{
    if (m == n)
    return n;
    return n + CalculateSummOfDigits(m, n - 1);
}
