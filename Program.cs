﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехназное число ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вторая цифра числа = { (x/10) % 10 }");
 