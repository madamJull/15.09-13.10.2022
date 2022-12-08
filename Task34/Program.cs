// 1.Задайте массив 2.заполненный случайными положительными трёхзначными числами. 3.Напишите программу, 
// 4.которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRnd(array);
// Console.WriteLine("Задан массив: ");
// PrintArray(array);
Console.WriteLine($"Задан массив: [ {string.Join(", ", array)} ]");
int count = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine($"Всего элементов в массиве {array.Length}, из них четными являются {count} элемента");

void FillArrayRnd(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,999);
    }
}
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
