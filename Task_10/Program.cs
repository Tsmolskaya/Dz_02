﻿// Задача 10:Напишите программу, которая принимает на вход трёхзначное число и 
// //на выходе показывает вторую цифру этого числа.

// //456 -> 5
// //782 -> 8
// //918 -> 1

Console.WriteLine("введите число от 100 до 999 ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((num % 100) / 10);