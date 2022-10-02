Console.WriteLine("Ведите целое числа, чтобы узнать является ли оно четным: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
Console.WriteLine("Да");
else 
{
    Console.WriteLine("Нет");
}
