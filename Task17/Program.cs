﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();
Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0)
{
    Console.WriteLine("Не соблюдено условие");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else 
{
    Console.WriteLine("4");
}