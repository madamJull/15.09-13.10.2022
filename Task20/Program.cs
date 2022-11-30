//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Console.Write("Введите x точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());

//√(xb - xa)2 + (ya - yb)2

double result = Math.Sqrt(Math.Pow(xb - xa,2) + Math.Pow(yb - ya,2));
Console.WriteLine(Math.Round(result,2,MidpointRounding.ToZero));//MidpointRounding.ToZero - округление в меньшую сторону