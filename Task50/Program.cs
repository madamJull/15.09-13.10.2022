// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Clear();
Console.WriteLine("Введите индекс строки массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[4, 4];

FillArrayRandom(numbers);

PrintArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Элемента с данными индексами в массиве нет");
}
else
{
    Console.WriteLine($"Элемент со значением индекса строки {n}  и индекса столбца {m} равен {numbers[n, m]}");
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100) / 10;
        }
    }
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

