// Задача 19
/*
  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да
*/

int GetValue(string message)
{
  int resultNumber = 0;
  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out resultNumber))
    {
      resultNumber = Math.Abs(resultNumber);
      while (resultNumber < 9999 || resultNumber > 100000)
      {
        Console.WriteLine("Вы ввели не пятизначное число");
        resultNumber = GetValue("Введите целое пятизначное число:");
      }
      break;
    }
    else
    {
      Console.WriteLine("Вы ввели не корректные данные. Повторите ввод!");
    }
  }
  return resultNumber;
}

int number = GetValue("Введите целое пятизначное число:");

void GetResult(int num)
{
  if (
    (number / 10000 == number % 10) &&
    ((number % 10000) / 1000 == (number % 100) / 10)
  )
  {
    Console.WriteLine($"Вы ввели {number} - это число-паллиндром!");
  }
  else
  {
    Console.WriteLine($"Вы ввели {number} - это число не является паллиндромом.");
  }
}

GetResult(number);




