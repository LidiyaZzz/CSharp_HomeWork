// Задача 29
/*
    Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
      1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
      6, 1, 33 -> [6, 1, 33]

    Напишите программу, которая принимает массив в виде строки, формирует из нее массив целых чисел и выводит полученный массив на экран.
   
*/

Console.WriteLine("Введите числа через запятую:");
string stringIn = Console.ReadLine();
string[] strOfNum = GetStringOfNumbers(stringIn);
int[] intNum = GetNumberArray(strOfNum);
// PrintStringArray(strOfNum);
Console.Write("Вы ввели числа ");
PrintNumberArray(intNum);

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


