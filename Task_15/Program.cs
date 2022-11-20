//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру дня недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
    Console.WriteLine("Понедельник");
if (num == 2)
    Console.WriteLine("Вторник");
if (num == 3)
    Console.WriteLine("Среда");  
if (num == 4)
    Console.WriteLine("Четверг");
if (num == 5)
    Console.WriteLine("Пятница");
if (num == 6)
    Console.WriteLine("Суббота-выходной"); 
if (num == 7)
    Console.WriteLine("Воскресенье-выходной");