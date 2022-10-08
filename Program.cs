// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введи трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);
Console.WriteLine("вторая цифра этого числа "+num1[1]);


// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267912 -> 6

Console.Clear();
Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);
if (num1.Length > 2)
{
  Console.WriteLine("третья цифра " + num1[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введи число, которое обозначает день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int num)
{
    if (num == 6 || num == 7) 
{
  Console.WriteLine("этот день выходной");
}
  else if (num < 1 || num > 7) 
  {
    Console.WriteLine("не день недели");
  }
  else Console.WriteLine("не выходной");
}
CheckingTheDayOfTheWeek(num);