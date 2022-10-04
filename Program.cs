/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = 0; int min = 0;

if (num > num2)
{
    max = num;
    min = num2;
}

else
{
    max = num2;
    min = num;
}
Console.WriteLine($"Наибольшее число: {max}");
Console.WriteLine($"Наименьшее число: {min}");