// Задача 64
/*
  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write(" \"");
PrintN(GetStartPosition(), 1);
Console.Write("\" ");

void PrintN(int startN, int i)
{
  if (startN >= i)
  {
    if (startN == i) Console.Write($"{startN}");
    else
    {
      Console.Write($"{startN}, ");
      startN--;
      PrintN(startN, i);
    }
  }
}

int GetStartPosition()
{
  Random random = new Random();
  int result = random.Next(4, 16);
  return result;
}