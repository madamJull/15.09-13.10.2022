// Напишите программу, которая принимает на вход число M и N и выдаёт произведение чисел от M до N.
// 2,4 -> 24 
// 1,5 -> 120

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsCorrectNumbers(m, n) ? $"Произведение чисел {m} и {n} = {FindProductNumbers(m, n)}" : "Введенные числа заданы неверно");

int FindProductNumbers(int num1, int num2)
{
    int prod = 1;
    for (int i = num1; i <= num2; i++)
    {
        prod = prod * i;
    }
    return prod;
}
bool IsCorrectNumbers(int num1, int num2)
{
    if(num1 < num2 && num1 != 0) return true;
    else return false;
}