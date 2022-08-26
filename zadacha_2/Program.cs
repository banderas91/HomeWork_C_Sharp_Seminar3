// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Ведите координаты первой точки: ");
Console.Write("X = ");
double x1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите координаты второй точки: ");
Console.Write("X = ");
double x2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Y = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1 - x2), 2)
              + Math.Pow((y1 - y2), 2)
              + Math.Pow((z1 - z2), 2));

Console.WriteLine($"Расстояние между точками = {result:F2}");
