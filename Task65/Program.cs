// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N с помощью рекурсии
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($" M = {m}, N = {n} -> ");
PrintValue (m, n); 

void PrintValue (int m, int n)
{
if (m > n) return;
Console.Write($" {m} ");
PrintValue(m + 1, n);
}