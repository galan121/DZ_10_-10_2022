﻿/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
 A (3,6,8); B (2,1,-7); C (0.0.0) -> 15.84
A (7,-5, 0); B (1,-1,9) C (0.0.0) -> 11.53    */

Console.WriteLine ("A (x1;y1;z1),B (x2;y2;z2), C(x3;y3;z3");
Console.Write("Введите x1: ");
int x1=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());      
Console.Write ("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());       // координаты первой точки .

Console.Write("Введите x2: ");
int x2=Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine()); 
 Console.Write ("Введите z2: ");                  
int z2 = Convert.ToInt32(Console.ReadLine());    //  координаты второй точки .

Console.Write("Введите x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z3: ");
int z3 = Convert.ToInt32(Console.ReadLine());  //   координаты третьей точки .
Console.WriteLine("ABC Lenght is: " + Math.Round(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)),3));

