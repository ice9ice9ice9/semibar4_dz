/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.WriteLine("Введите число: "); 
string num = Console.ReadLine();

int count = num.Length;

for (int i = 0; i < count; i++)
{
    Console.WriteLine(num[i]);
}


