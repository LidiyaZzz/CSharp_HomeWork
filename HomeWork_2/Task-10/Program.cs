// Задача 10
/*
  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1
*/

/* Вариант с Random
  int GetRandomNumber(int leftBound, int rightBound)
  {
    Random random = new Random();
    return random.Next(leftBound, rightBound);
  }
  int num = GetRandomNumber(100, 1000);
*/

/* Вариант с вводом
*/

Console.WriteLine("Введите целое трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSecondDigitOfNumber(int number)
{
  int result = Math.Abs((number % 100) / 10);
  return result;
}

Console.WriteLine($"целое трехзначное число: {num}");
Console.WriteLine($"вторая цифра этого числа: {GetSecondDigitOfNumber(num)}");
