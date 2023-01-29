// Задача 38
/*
  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76
*/

double GetRandomNumber()
{
  Random randomPartOfNumber = new Random();
  double randomNumber = Math.Round(randomPartOfNumber.NextDouble(), 2) + randomPartOfNumber.Next(-99, 100);

  return randomNumber;
}

double[] GetRandomNumberArray(int lengthArray)
{
  double[] numberArray = new double[lengthArray];

  for (int i = 0; i < numberArray.Length; i++)
  {
    numberArray[i] = GetRandomNumber();
  }

  return numberArray;
}

void PrintNumberArray(double[] array)
{
  Console.Write($"[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1) Console.Write($"{array[i]}");
    else Console.Write($"{array[i]}, ");
  }
  Console.Write($"]");
}

double GetDiffMaxAndMinElements(double[] array)
{
  double minElem = array[0];
  double maxElem = array[0];

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < minElem) minElem = array[i];
    if (array[i] > maxElem) maxElem = array[i];
  }

  return Math.Round((maxElem - minElem), 2);
}

double[] numberArray = GetRandomNumberArray(4);

Console.Write("В произвольном массиве вещественных чисел ");
PrintNumberArray(numberArray);
Console.WriteLine($" разница между максимальным и минимальным элементами массива = {GetDiffMaxAndMinElements(numberArray)}");


