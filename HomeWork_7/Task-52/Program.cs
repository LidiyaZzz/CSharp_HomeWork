// Задача 52
/*
  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
      1 4 7 2
      5 9 2 3
      8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// Часть-заглушка - создаем рандомный заполненный массив
int[,] matrixRandomArray = FillRandomNumber(GetTwoDimensional(3, 4));
Console.WriteLine("Зададим двумерный массив: ");
PrintArray(matrixRandomArray);
Console.WriteLine();

double[] averageValuesArray = GetAverage(matrixRandomArray);
Console.WriteLine("среднее арифметическое значение элементов в каждом столбце: ");
PrintNumberArray(averageValuesArray);

// методы для решения задачи 
void PrintNumberArray(double[] array)
{
  Console.Write($"(");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1) Console.Write($"{array[i]}");
    else Console.Write($"{array[i]}; ");
  }
  Console.Write($")");
}

double[] GetAverage(int[,] array)
{
  double[] averageValues = new double[array.GetLength(1)];

  for (int j = 0; j < array.GetLength(1); j++)
  {
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
      result += array[i, j];
    }
    averageValues[j] = Math.Round((result / array.GetLength(0)), 1, MidpointRounding.ToNegativeInfinity);
  }

  return averageValues;
}



// создаем массив и заполняем его
int[,] GetTwoDimensional(int oneValue, int twoValue)
{
  int[,] matrix = new int[oneValue, twoValue];
  return matrix;
}

int[,] FillRandomNumber(int[,] matrix)
{
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

