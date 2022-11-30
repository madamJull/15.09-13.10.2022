// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите x точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z точки A: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

//√(xb - xa)2 + (ya - yb)2 + (zb - za)2

double result = Math.Sqrt(Math.Pow(xb - xa,2) + Math.Pow(yb - ya,2) + Math.Pow(zb - za,2));
Console.WriteLine(Math.Round(result,2,MidpointRounding.ToZero));
