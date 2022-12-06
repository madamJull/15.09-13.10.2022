// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int [] array = new int [8];

for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(1, 100);
    Console.Write(" " + FillArray (i) + " ");
 }

int FillArray (int a)
{
    return array[a];
}

Console.WriteLine($"Выведен массив: [{String.Join(", ", array)}]");