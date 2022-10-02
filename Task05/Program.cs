Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int x = -num;
while(x <= num)
{
    Console.Write($"{x},");
    x++;
}
