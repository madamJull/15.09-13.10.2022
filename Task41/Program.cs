// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите положительные и отрицательные числа через пробел: ");

int [] array = StringToNum(Console.ReadLine());

Console.WriteLine($"Задан массив: [ {string.Join(", ", array)} ]");

int count = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] > 0)
count++; 

Console.WriteLine($"Во введенном массиве  содержится {count} чисел больше 0");

int[] StringToNum(string inputArray)
{
    int count = 1;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray [i] == ' ')
        {
            count++;
        }
    }

    int[] num = new int [count];
    int index = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        string temp = " ";

        while (inputArray [i] != ' ')
        {
        if(i != inputArray.Length - 1)
        {
            temp += inputArray [i].ToString();
            i++;
        }
        else
        {
            temp += inputArray [i].ToString();
            break;
        }
        }
        num[index] = Convert.ToInt32(temp);
        index++;
    }
    return num;
}
