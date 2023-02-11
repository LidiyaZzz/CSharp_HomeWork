// Задача 54
/*
  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
      1 4 7 2
      5 9 2 3
      8 4 2 4
    В итоге получается вот такой массив:
      7 4 2 1
      9 5 3 2
      8 4 4 2
*/

// Cоздаем рандомный заполненный массив
int[,] matrixRandomArray = GetTwoDimensional(3, 4);
Console.WriteLine("Зададим двумерный массив: ");
PrintArray(matrixRandomArray);

// Сортируем по убыванию элементы строк
int[,] sortMatrix = GetSortMatrix(matrixRandomArray);
Console.WriteLine(" ");
Console.WriteLine("Вернем упорядоченные по убыванию элементы каждой строки двумерного массива");
PrintArray(matrixRandomArray);

// 
int[,] GetSortMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int[] sortAray = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sortAray[j] = matrix[i, j];
    }
    Array.Sort(sortAray);
    Array.Reverse(sortAray);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = sortAray[j];
    }
  }

  return matrix;
}

// создаем массив и заполняем его
int[,] GetTwoDimensional(int oneValue, int twoValue)
{
  int[,] matrix = new int[oneValue, twoValue];
  Random random = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = random.Next(0, 100);
    }
  }

  return matrix;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

