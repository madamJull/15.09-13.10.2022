// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Clear();

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Натуральные четные числа от {m} до {n}: ");

PrintValue (m, n); 

void PrintValue (int m, int n)
{
if (m > n)return;
{
    if (m % 2 == 0)
    Console.Write($"{m}, ");
    PrintValue(m+1, n);
}
}
