// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRnd(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;
Console.WriteLine($"Задан массив: [ {string.Join(", ", array)} ]");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }

}

Console.WriteLine($"Всего элементов в массиве {array.Length}. максимальным элементом массива является = {max}, минимальным элементом массива является = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением массива составляет = {(Math.Round(max - min,2,MidpointRounding.ToZero))}");

void FillArrayRnd(double[] array)
{
    var rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(rnd.Next(100,1000)) / 100;            
        }
}
