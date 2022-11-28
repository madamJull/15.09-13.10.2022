// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа. 
Console.Clear();
Console.WriteLine("Введите целое число  от 10 до 99 ");
int num = new Random().Next(10, 100);
int num1 = num/10;
int num2 = num %10;
Console.WriteLine($"Число {num}");
if (num1 == num2)
    Console.WriteLine("Цифры числа равны ");
else if(num1 > num2)
    Console.WriteLine($"Максимальной цифрой числа является {num1}");
else 
    Console.WriteLine($"Максимальной цифрой числа является {num2}");
