// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
int [] FillArray(int newarray)
{
    Random rnd = new Random();
    int [] array = new int[newarray];
    for (int i = 0; i < newarray; i++)
    {
        array[i] = rnd.Next(0,2);
    }
    return array;
}
// void GetOutputArray(int[] a)
// {
//     for(int i = 0; i < a.Lenght; i++)
//     {
//         Console.Write($"{a[i]} ");
//     }
// }
int[] array = FillArray(8);
Console.WriteLine(String.Join(", ", array));
