// Задача 41
/*
  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
  вводим через один Enter (разбиваем через Split())
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
*/


Console.WriteLine("Введите числа через запятую:");
string stringIn = Console.ReadLine();
string[] strOfNum = GetStringOfNumbers(stringIn);
int[] intNum = GetNumberArray(strOfNum);
// PrintStringArray(strOfNum);
Console.Write("Вы ввели числа ");
PrintNumberArray(intNum);
Console.WriteLine();
Console.WriteLine($"Из введеных чисел {GetQuantityN(intNum)} являются положительными");


// получает строковый массив чисел
string[] GetStringOfNumbers(string inputText)
{
  string outputText = "";

  for (int i = 0; i < inputText.Length; i++)
  {
    if (Char.IsLetter(inputText, i)) outputText += ',';
    else outputText += inputText[i];
  }
  char[] separators = new char[] { ' ', '.', ',' };

  return outputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
}

// получает массив чисел int из полностью обработанной строки
int[] GetNumberArray(string[] strArray)
{
  int[] numArray = new int[strArray.Length];
  int resultNumber = 0;

  for (int i = 0; i < strArray.Length; i++)
  {
    if (int.TryParse(strArray[i], out resultNumber)) numArray[i] = resultNumber;
    else continue;
  }

  return numArray;
}

// получает количество положительных чисел
int GetQuantityN(int[] numArray)
{
  int count = 0;
  foreach (int num in numArray)
  {
    if (num > 0) count++;
    else continue;
  }
  return count;
}

void PrintStringArray(string[] array)
{
  Console.Write($"[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1) Console.Write($"{array[i]}");
    else Console.Write($"{array[i]}, ");
  }
  Console.Write($"]");
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


