﻿// Задача 25
/*
  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/

int GetValue(string message)
{
  int resultNumber = 0;
  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out resultNumber))
    {
      break;
    }
    else
    {
      Console.WriteLine("Вы ввели не корректные данные. Повторите ввод!");
    }
  }
  return resultNumber;
}

int number = GetValue("Введите целое число:");
int valuePower = Math.Abs(GetValue("Введите степень, в которую необходимо возвести число:"));


// Вариант 1 через цикл
int numberPower(int num, int pow)
{
  int result = num;
  if (pow == 0) result = 1;
  else
  {
    for (int i = 1; i < pow; i++)
    {
      result = result * num;
    }
  }
  return result;
}
Console.WriteLine($"Результат выполнения возведения в степень по первому варианту решения: {numberPower(number, valuePower)}");

// Вариант 2: через цикл как то неудобно, функцией Math.Pow проще, или?

int ResultPower(int num, int power)
{
  int result;
  if (valuePower == 0) result = 1;
  else result = Convert.ToInt32(Math.Pow(num, power));
  return result;
}
Console.WriteLine($"Результат выполнения возведения в степень по второму варианту решения: {ResultPower(number, valuePower)}");