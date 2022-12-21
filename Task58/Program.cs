// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int size = InputInt("Введите размер двух двумерных матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];

FillArrayRandom(matrixA);

FillArrayRandom(matrixB);

int[,] matrixC = new int[size, size];

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}

void FillArrayRandom(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0,10);
        }
    }
    return;
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

Console.WriteLine("Матрица А: ");
PrintArray(matrixA);

Console.WriteLine("Матрица В: ");
PrintArray(matrixB);

Console.WriteLine("Произведение матриц А*В: ");
PrintArray(matrixC);