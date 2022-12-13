// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRnd(array);
int sum = 0;

Console.WriteLine($"Задан массив: [ {string.Join(", ", array)} ]");

for(int i = 1; i < array.Length; i += 2)
    sum = sum + array[i];
    
Console.WriteLine($"Всего элементов в массиве {array.Length}, сумма элементов, стоящих на нечётных позициях составляет = {sum}");

void FillArrayRnd(int[] array)
{
    var rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1,100);
        }
}
