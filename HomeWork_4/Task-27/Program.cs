// Задача 27
/*
   Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/

int number = GetValue("Введите целое число: ");
Console.WriteLine($"сумма цифр числа {number}: {SumDigitOfNum(CountDigit(number), number)}");


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
  return Math.Abs(resultNumber);
}

int CountDigit(int num)
{
  int countDigit = num;
  int count = 0;

  while (countDigit != 0)
  {
    countDigit = countDigit / 10;
    count++;
  }
  return count;
}

int SumDigitOfNum(int count, int num)
{
  int result = 0;
  for (int i = count; i > 0; i--)
  {
    result += (num % Convert.ToInt32(Math.Pow(10, i))) / Convert.ToInt32(Math.Pow(10, (i - 1)));
  }
  return result;
}



