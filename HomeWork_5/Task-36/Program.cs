// Задача 36
/*
  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
*/


int[] numberArray = GetRandomNumberArray(4, -99, 100);

Console.Write("В произвольном массиве ");
PrintNumberArray(numberArray);
Console.WriteLine($" сумма элементов, стоящих на нечётных позициях = {GetSumElementsAtOddPositions(numberArray)}");


int[] GetRandomNumberArray(int lengthArray, int leftBound, int rightBound)
{
  int[] numberArray = new int[lengthArray];
  Random random = new Random();

  for (int i = 0; i < numberArray.Length; i++)
  {
    numberArray[i] = random.Next(leftBound, rightBound);
  }

  return numberArray;
}

void PrintNumberArray(int[] array)
{
  Console.Write($"[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1) Console.Write($"{array[i]}");
    else Console.Write($"{array[i]}, ");
  }
  Console.Write($"]");
}

int GetSumElementsAtOddPositions(int[] array)
{
  int sum = 0;

  for (int i = 1; i < array.Length; i++)
  {
    if (i % 2 != 0) sum += array[i];
    else continue;
  }
  return sum;
}
