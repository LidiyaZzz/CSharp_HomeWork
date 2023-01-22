
// Задача 23
/*
  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
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

void GetListCubs(int value)
{
  Console.WriteLine($"таблица кубов чисел от 1 до {value}: ");
  if (value > 0)
  {
    for (int i = 1; i <= value; i++)
    {
      Console.WriteLine(Math.Pow(i, 3));
    }
  }
  if (value <= 0)
  {
    for (int i = 1; i >= value; i--)
    {
      Console.WriteLine(Math.Pow(i, 3));
    }
  }
}

int finishNumber = GetNumber("Введите целое число");
GetListCubs(finishNumber);