// Задача 66
/*
  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

int leftN = GetPosition(1, 4);
int rightN = GetPosition(5, 15);
int result = leftN;

Console.Write("\"");
PrintN(leftN, rightN);
Console.Write("\" ");

Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке от {leftN} до {rightN}: {GetSumElements(leftN, rightN)}");

int GetSumElements(int start, int end)
{
  if (start == end) return start;
  else return start + GetSumElements(start + 1, end);
}

void PrintN(int startN, int endN)
{
  if (startN <= endN)
  {
    if (startN == endN) Console.Write($"{startN}");
    else
    {
      Console.Write($"{startN}, ");
      startN++;
      PrintN(startN, endN);
    }
  }
}

int GetPosition(int startPos, int endPos)
{
  Random random = new Random();
  int result = random.Next(startPos, endPos);
  return result;
}