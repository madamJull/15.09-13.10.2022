// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано случайное {num}");
int num1 = num / 100;
int num2 = num % 10;
int res = num1 * 10 + num2;
Console.WriteLine($"После удаления второй цифры получилось двузначное число {res}");
