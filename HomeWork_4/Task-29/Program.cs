// Задача 29
/*
    Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
      1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
      6, 1, 33 -> [6, 1, 33]
*/

int[] numberArray = new int[8];
GetRandomNumberArray(1, 100, numberArray);
PrintNumberArray(numberArray);


void GetRandomNumberArray(int leftBound, int rightBound, int[] array)
{
  Random random = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(leftBound, rightBound);
  }
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



