// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2)
{
  Console.WriteLine("Третья цифра  " + numText[2]);
}
else 
  Console.WriteLine("Третьей цифры нет");