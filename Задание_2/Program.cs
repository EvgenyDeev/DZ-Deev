/* Задание №2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.Clear();
int a = Console.WriteLine("Введите значение a: ");
int b = Console.WriteLine("Введите значение b: ");
if (int a > int b)
{
    Console.WriteLine(int a);
}
else
{
    Console.WriteLine(int b);
}