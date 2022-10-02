Console.WriteLine("Введите трехзачное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;
Console.WriteLine($"Последней цифрой числа {number} является {result}");