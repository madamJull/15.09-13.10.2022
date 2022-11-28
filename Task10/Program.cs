// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзачное число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 100/10;
Console.WriteLine($"Второй цифрой числа {number} является {result}");
