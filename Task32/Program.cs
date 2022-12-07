// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
Console.Clear();
Console.Write("Введите число элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, -99, 99);
Console.WriteLine($"Оригинальный массив:    [ {string.Join(", ", array)} ]");

array = InverseArray(array);
Console.WriteLine($"Инвертированный массив: [ {string.Join(", ", array)} ]");

int[] InverseArray(int[] arr)
{
    for (int i = 1; i < arr.Length; i++) arr[i] *= -1;
    return arr;
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
