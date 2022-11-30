// Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт таблицу кубов чисел от N до M.
// 2,3 -> 8, 27
// 1,5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите первое целое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int count = n1;
while (count < n2)
{
    Console.Write($"{count * count * count}, ");
    count++;
}
Console.Write($"{n2 * n2 * n2} ");
