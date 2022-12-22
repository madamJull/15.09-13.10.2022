// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N с помощью рекурсии
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintValue (1, n); 

void PrintValue (int m, int max)
{
if (m > max) return;
Console.Write($" {m} ");
PrintValue(m + 1, n);
}