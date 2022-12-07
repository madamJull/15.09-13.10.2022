// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.Write("Введите число элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, 0, 99);

Console.WriteLine($"Массив: [ {string.Join(", ", array)} ]");

Console.Write("Введите число для поиска : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNumberFromArray(array, n) ? $"Число {n} присутствует в массиве."
     : $"Число {n} отсутствует в массиве.");

bool FindNumberFromArray(int[] arr, int s)
{
    for (int i = 0; i < arr.Length; i++) if (arr[i] == s) return true;
    return false;
}

int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 1; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}