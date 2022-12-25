// Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Наибольший общий делитель чисел ({m}, {n}) = {Nod(m, n)}");

int Nod(int n, int m)
{
    if (n % m == 0)
        return m;
    return Nod(m, n % m);
}