﻿// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка

// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

Console.WriteLine("Введите координаты X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}