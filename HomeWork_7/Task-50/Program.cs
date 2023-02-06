// Задача 50
/*
  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив:
      1 4 7 2
      5 9 2 3
      8 4 2 4
  пользователь вводит индексы 10, 10 - такого элемента нет.
  пользователь вводите индексы 0, 2 - выводим элеменет 7
*/

// Часть-заглушка - создаем рандомный заполненный массив
int[,] matrixRandomArray = GetTwoDimensional(4, 5);
Console.WriteLine("Зададим двумерный массив");
PrintArray(matrixRandomArray);
Console.WriteLine();

// получаем от пользователя позицию элемента
int[] elementPosition = { GetNumber("Введите первую позицию элемента"), GetNumber("Введите вторую позицию элемента") };
PrintNumberArray(elementPosition);

// проверяем, есть ли такая позиция в массиве и выводим результат
bool position = IsPosition(elementPosition, matrixRandomArray);
Console.WriteLine(position);

if (position)
{
  int elementByPosition = GetElementByPosition(matrixRandomArray, elementPosition);
  Console.WriteLine($"В заданном массиве на указанной позиции находится элемент со значением {elementByPosition}");
}
else
{
  Console.WriteLine($"В заданном массиве на указанной позиции элемента нет!");
}

// методы для решения задачи 
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

bool IsPosition(int[] position, int[,] array)
{
  bool check = false;
  if (position[0] < array.GetLength(0) && position[1] < array.GetLength(1)) check = true;

  return check;
}

int GetElementByPosition(int[,] array, int[] position)
{
  int element = array[position[0], position[1]];
  return element;
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


