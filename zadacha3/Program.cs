﻿/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split()) */

Console.WriteLine("Введите цифры: "); 
string tsifri = Console.ReadLine();
string[] array = tsifri.Split('_');

foreach (var tsifra in array)
{
    Console.WriteLine($"[{tsifra}]");
}
