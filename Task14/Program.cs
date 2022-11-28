// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
Console.Clear();
Console.WriteLine("Введите целое число: ");
double num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? $"Число {num} кратно 7 и 23" 
: $"Число {num} не кратно 7 и 23");
