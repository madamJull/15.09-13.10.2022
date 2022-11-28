// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления. 
Console.Clear();
Console.WriteLine("Ведите два числа, чтобы узнать является ли второе число кратным первому");
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int ost = num1 % num2;
Console.WriteLine(ost == 0 ? $"Число {num1} кратно числу {num2}" 
: $"Число {num1} не кратно числу {num2}, остаток от деления равен {ost}");
