// Задача 29
/*
    Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
      1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
      6, 1, 33 -> [6, 1, 33]

    Следуя из примеров предполагаемых решений, делаем вывод, что массив может состоять 
    из количества элементов не превышающих 8. Переформулируем задачу так:
    Напишите программу, которая задаёт массив из СКОЛЬКИ ХОТИТЕ элементов, МОЖНО И ИЗ 8 
    и выводит их на экран.
   
*/

int[] numberArray = new int[GetRandomLengthArray(1, 9)];
GetRandomNumberArray(1, 100, numberArray);
PrintNumberArray(numberArray);

int GetRandomLengthArray(int leftBound, int rightBound)
{
  int length = new Random().Next(leftBound, rightBound);
  return length;
}

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
