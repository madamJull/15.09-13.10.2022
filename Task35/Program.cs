// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
Console.Write("Введите число элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало интервала : ");
int iMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец интервала : ");
int iMax = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, 0, 99);

Console.WriteLine($"Оригинальный массив:    [ {string.Join(", ", array)} ]");

Console.WriteLine($"В интервале чисел от {iMin} до {iMax} находятся {CountArrayElement(array,iMin,iMax)} элементов");

int CountArrayElement(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)        
        if (arr[i] >= min && arr[i] <= max) count++;
    return count;
}

int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int IsExistNumInArray (int [] arr)

{ 
    int count = 0;
    for (int i =0; i < arr.Length; i++)
    {
        
        if ( arr [i] >=10 && arr [i] <= 99 )
        count++;
    }

return count;

}