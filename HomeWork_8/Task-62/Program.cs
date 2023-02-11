// Задача 62
/*
  Напишите программу, которая заполнит спирально массив 4 на 4.
  Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
*/

int[,] table = new int[4, 4];
FillArray(GetStartPosition(), table);
Console.WriteLine("Заполним массив 4 на 4 возрастающими значениями по спирали по часовой стрелке: ");
PrintArray(table);

int GetStartPosition()
{
  Random random = new Random();
  int result = random.Next(1, 9);
  return result;
}

void FillArray(int startPosition, int[,] matrix)
{
  int startX = 0;
  int endX = matrix.GetLength(0) - 1;
  int startY = 0;
  int endY = matrix.GetLength(1) - 1;

  while (startX <= endX && startY <= endY)
  {
    for (int i = startX; i <= endX; i++)
    {
      matrix[startY, i] = startPosition++;
    }
    startY++;

    for (int j = startY; j <= endY; j++)
    {
      matrix[j, endX] = startPosition++;
    }
    endX--;

    for (int i = endX; i >= startX; i--)
    {
      matrix[endY, i] = startPosition++;
    }
    endY--;

    for (int j = endY; j >= startY; j--)
    {
      matrix[j, startX] = startPosition++;
    }
    startX++;
  }

}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
      else Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

