﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите первую координату в точке А");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату в точке А");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую координату в точке B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату в точке B");
int y2 = Convert.ToInt32(Console.ReadLine());

// double coordinata1 = Math.Pow((x2-x1),2);
// double coordinata2 = Math.Pow((y2-y1),2);
double lenght = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

Console.WriteLine(lenght);
