﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int n = number.Length;

if (n == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Данное число является палиндромом");
    }
}
else
{
    Console.WriteLine("Данное число не является пятизначным");
}