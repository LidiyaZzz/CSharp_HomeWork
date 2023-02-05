// Задача 13
/*
  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6
*/

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number > -100)
{
  Console.WriteLine($"Вы ввели {number}, у данного числа третьей цифры нет");
}
else if (number >= 100 || number <= -100)
{
  Console.WriteLine($"Вы ввели {number}, у данного числа третья цифра {GetThirdDigitOfNumber(number)}");
}


int GetThirdDigitOfNumber(int num)
{
  num = num - (num % 100);
  int result = Math.Abs((num % 1000) / 100);
  return result;
}
