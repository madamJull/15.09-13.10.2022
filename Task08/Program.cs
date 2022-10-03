Console.WriteLine("Введите целое число, чтобы узнать все четные значения от 1 до введенного числа");
int num = Convert.ToInt32(Console.ReadLine());
int x = 1;
while(x <= num)
{
    if (x % 2 == 0)
    Console.Write($"{x },");
    {
        x++;
    }
}


