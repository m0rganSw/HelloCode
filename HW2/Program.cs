﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
////////////////////////////////////////////////////////////////////////////
/*
Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int result;
if (a <= 999)
{
    result = ((a/10)%10);
    Console.WriteLine(result);
    //int a = Convert.ToInt32(Console.ReadLine());
}
else
{
    Console.WriteLine("Сказано - введи трехначное число");
    //int a = Convert.ToInt32(Console.ReadLine());
}
*/
///////////////////////////////////////////////////////////////////////////

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
////////////////////////////////////////////////////////////////////////////
/*
Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int result;
if (a <= 999 & a >=100)
{
    result = (a%10);
    Console.WriteLine(result);
    //int a = Convert.ToInt32(Console.ReadLine());
}
else if (a < 100)
{
    Console.WriteLine("Третей цифры нет");
    //int a = Convert.ToInt32(Console.ReadLine());
}
*/
///////////////////////////////////////////////////////////////////////////
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/
////////////////////////////////////////////////////////////////////////////
/*
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("этот день выходной ");
  }
  else 
  {
  Console.WriteLine("этот день не выходной ");
  }
}

CheckingTheDayOfTheWeek(dayNumber);
*/
////////////////////////////////////////////////////////////////////////////