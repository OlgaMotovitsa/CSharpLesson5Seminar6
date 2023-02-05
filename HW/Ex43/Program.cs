// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Random rnd = new Random();

int b1 = rnd.Next(1, 5);
int k1 = rnd.Next(1, 5);
int b2 = rnd.Next(1, 5);
int k2 = rnd.Next(1, 5);

System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");

int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;
Console.WriteLine($"Точка пересечения 2х прямых: ({x}; {y})");

