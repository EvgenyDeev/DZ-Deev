﻿/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b & a > c)
{
    Console.WriteLine($"максимальное число {a}");
}
if(b > a & b > c)
{
    Console.WriteLine($"максимальное число {b}");
}
if(c > a & c > b)
{
    Console.WriteLine($"максимальное число {c}");
}
