// Задача 47
/*
  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
double[,] myArray = GetTwoDimensional(rows, columns);
Console.WriteLine(
  $"Зададим двумерный массив размером {myArray.GetLength(0)}х{myArray.GetLength(1)}, заполненный случайными вещественными числами: "
  );
PrintArray(myArray);


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

double[,] GetTwoDimensional(int oneValue, int twoValue)
{
  double[,] matrix = new double[oneValue, twoValue];

  Random random = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = Math.Round(random.NextDouble(), 1) + random.Next(-99, 100);
    }
  }

  return matrix;
}

void PrintArray(double[,] array)
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


