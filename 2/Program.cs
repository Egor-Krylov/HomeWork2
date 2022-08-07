// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitPower = 1;
int thirdDigit = 0;

while (number / digitPower != 0) digitPower *= 10;

if (digitPower <= 100) Console.WriteLine("нет третьей цифры");
else
{
    thirdDigit = number / (digitPower / 1000) % 10;
    Console.WriteLine("третья цифра: " + thirdDigit);
}