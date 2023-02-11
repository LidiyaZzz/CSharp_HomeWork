// Задача 58
/*
  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
      2 4 | 3 4
      3 2 | 3 3
    Результирующая матрица будет:
      18 20  2x3+4x3 18/ 2x4+4x3 20
      15 18  3x3+2x3 15/ 3x4+2x3 18
*/

// создаем рандомные матрицы
int columns = GetNumber("Введите количество столбцов матрицы A: ");
int rowA = GetNumber("Введите количество рядов матрицы A, равное количеству столбцов матрицы B: ");
int rowB = GetNumber("Введите количество рядов матрицы B: ");

int[,] matrixRandomA = GetTwoDimensional(columns, rowA);
int[,] matrixRandomB = GetTwoDimensional(rowA, rowB);
Console.WriteLine("Зададим две матрицы: ");
PrintArray(matrixRandomA);
Console.WriteLine();
PrintArray(matrixRandomB);
Console.WriteLine();

Console.WriteLine("Произведение двух матриц: ");
PrintArray(GetResultMatrixMultiplication(matrixRandomA, matrixRandomB));

int[,] GetResultMatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
  int[,] matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
  for (int i = 0; i < matrixA.GetLength(0); i++)
  {
    for (int k = 0; k < matrixB.GetLength(1); k++)
    {
      for (int j = 0; j < matrixB.GetLength(0); j++)
      {
        matrix[i, k] += matrixA[i, j] * matrixB[j, k];
      }
    }
  }

  return matrix;
}


// создаем массив и заполняем его
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

int[,] GetTwoDimensional(int oneValue, int twoValue)
{
  int[,] matrix = new int[oneValue, twoValue];
  Random random = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = random.Next(0, 10);
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



