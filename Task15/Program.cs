// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7: ");
string numDay = Console.ReadLine();
if (numDay == "6" || numDay == "7")
{
    Console.WriteLine("Ура! Сегодня выходной!");
}
else 
{
    Console.WriteLine("Сегодня рабочий день(");
}
