// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите k1, b1, k2, b2");
int k1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());
double x = (double) (b2-b1) / (k1-k2);
double y = (double) (k1*x+b1);
Console.WriteLine($"Координата точки пересечения равна ({x};{y})" );
