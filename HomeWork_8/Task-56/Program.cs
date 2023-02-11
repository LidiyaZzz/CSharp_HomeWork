// Задача 56
/*
  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
      1 4 7 2
      5 9 2 3
      8 4 2 4
      5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// создаем рандомный заполненный массив
int[,] matrixRandomArray = GetTwoDimensional(5, 4);
Console.WriteLine("Зададим двумерный массив: ");
PrintArray(matrixRandomArray);
Console.WriteLine();

// находим строку с наименьшей суммой элементов
int[] sumOfValuesArray = GetSumOfValuesArray(matrixRandomArray);
Console.WriteLine("суммы значений строк массива:");
PrintNumberArray(sumOfValuesArray);
Console.WriteLine();
Console.WriteLine($"номер строки с наименьшей суммой элементов: {GetMinValue(sumOfValuesArray)}");


// методы для решения задачи 
int[] GetSumOfValuesArray(int[,] array)
{
  int[] sumValues = new int[array.GetLength(0)];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    int result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      result += array[i, j];
    }
    sumValues[i] = result;
  }

  return sumValues;
}

void PrintNumberArray(int[] array)
{
  Console.Write($"(");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1) Console.Write($"{array[i]}");
    else Console.Write($"{array[i]}; ");
  }
  Console.Write($")");
}

int GetMinValue(int[] array)
{
  int result = array[0];
  int row = 1;

  for (int i = 0; i < array.Length; i++)
  {
    if (result > array[i])
    {
      result = array[i];
      row++;
    }
  }

  return row;
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


