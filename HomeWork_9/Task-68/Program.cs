// Задача 68
/*
  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
*/
int numM = GetNumber("Введите неотрицательное число m: ");
int numN = GetNumber("Введите неотрицательное число n: ");
Console.WriteLine($"значение функции Аккермана при m = {numM}, n = {numN}: {Akkerman(numM, numN)}");

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
    return Akkerman(n - 1, 1);
  else
    return Akkerman(n - 1, Akkerman(n, m - 1));
}

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
  return Math.Abs(resultNumber);
}


