// Задача 60
/*
  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
  
  Массив размером 2 x 2 x 2
      66(0,0,0) 25(0,1,0)
      34(1,0,0) 41(1,1,0)
      27(0,0,1) 90(0,1,1)
      26(1,0,1) 55(1,1,1)
*/


int[,,] threeDimensional = GetThreeDimensional(2, 3, 2);
Console.WriteLine("Трёхмерный массив из неповторяющихся двузначных чисел с индексами каждого элемента: ");
PrintArray(threeDimensional);

int[] GerUniqueNumbersArray(int length)
{
  int[] numbersArray = new int[length];
  Random random = new Random();

  for (int i = 0; i < numbersArray.Length; i++)
  {
    int num = random.Next(10, 100);

    for (int j = 0; j < i; j++)
    {
      if (num == numbersArray[j])
      {
        num = random.Next(10, 100);
        j = -1;
      }
    }

    numbersArray[i] = num;
  }

  return numbersArray;
}

int[,,] GetThreeDimensional(int oneValue, int twoValue, int threeValue)
{
  int[,,] matrix = new int[oneValue, twoValue, threeValue];
  int lengthArray = oneValue * twoValue * threeValue;
  int[] numbersA = GerUniqueNumbersArray(lengthArray);

  int n = 0;
  while (n < numbersA.Length - 1)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
          matrix[i, j, k] = numbersA[n];
          n++;
        }
      }
    }
  }

  return matrix;
}

void PrintArray(int[,,] array)
{
  for (int k = 0; k < array.GetLength(2); k++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
      }
      Console.WriteLine();
    }
  }
}

