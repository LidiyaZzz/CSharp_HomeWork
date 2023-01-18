// Задача 13
/*
  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6
*/

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

int[] GetArrayDidgital(int num)
{
  string numString = num.ToString();
  int[] arrDidgitalOfNum = new int[numString.Length];

  for (int i = 0; i < arrDidgitalOfNum.Length; ++i)
  {
    arrDidgitalOfNum[i] = int.Parse($"{numString[i]}");
  }
  return arrDidgitalOfNum;
}

void GetThirdDigit(int[] numArray)
{
  if (numArray.Length < 3)
  {
    Console.WriteLine("Данное число менее 100 и не имеет третьей цифры");
  }
  else
  {
    Console.WriteLine($"В данном числе третья цифра {numArray[numArray.Length - 3]}");
  }
}

int[] arrayOfNumber = GetArrayDidgital(number);
GetThirdDigit(arrayOfNumber);


