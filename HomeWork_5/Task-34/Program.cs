// Задача 34
/*
  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2
*/

int[] numberArray = GetRandomNumberArray(5, 100, 1000);
Console.Write("В произвольном массиве ");
PrintNumberArray(numberArray);
Console.WriteLine($" количество четных элементов {GetQuantityEvenNumbers(numberArray)}");


int[] GetRandomNumberArray(int lengthArray, int leftBound, int rightBound)
{
  int[] numberArray = new int[lengthArray];
  Random rnd = new Random();

  for (int i = 0; i < numberArray.Length; i++)
  {
    numberArray[i] = rnd.Next(leftBound, rightBound);
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

int GetQuantityEvenNumbers(int[] array)
{
  int count = 0;
  foreach (int num in array)
  {
    if (num % 2 == 0) count++;
    else continue;
  }
  return count;
}