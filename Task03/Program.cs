Console.WriteLine("Введите число от 1 до 7");
string numDay = Console.ReadLine();
if (numDay == "1")
{
    Console.WriteLine("Monday");
}
else if(numDay == "2")
{
    Console.WriteLine("Tuesday");
}
else if(numDay == "3")
{
    Console.WriteLine("Wednesday");
}
else if(numDay == "4")
{
    Console.WriteLine("Thursday");
}
else if(numDay == "5")
{
    Console.WriteLine("Friday");
}
else if(numDay == "6")
{
    Console.WriteLine("Saturday");
}
else if(numDay == "7")
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Вы ввели не верное число");
}
