// Задача 43
/*
  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[] coordinatesPoint = GetCoordinatesPoint(
  GetNumber("Введите угловой коэффициент первой прямой (k1):"),
  GetNumber("Введите смещение первой прямой по оси Y (b1):"),
  GetNumber("Введите угловой коэффициент первой второй (k2):"),
  GetNumber("Введите смещение первой второй по оси Y (b2):"));

Console.Write("Координата точки пересечения двух прямых: ");
PrintNumberArray(coordinatesPoint);


double GetNumber(string message)
{
  double resultNumber = 0;
  while (true)
  {
    Console.WriteLine(message);

    if (double.TryParse(Console.ReadLine(), out resultNumber))
    {
      break;
    }
    else
    {
      Console.WriteLine("Вы ввели не корректные данные. Повторите ввод!");
    }
  }
  return resultNumber;
}

double[] GetCoordinatesPoint(double k1, double b1, double k2, double b2)
{
  double xPoint = (b2 - b1) / (k1 - k2);
  double yPoint = (k2 * b1 - k1 * b2) / (k2 - k1);
  double[] coordinatesPoint = { xPoint, yPoint };

  return coordinatesPoint;
}

void PrintNumberArray(double[] array)
{
  Console.Write($"(");
  for (int i = 0; i < array.Length; i++)
  {
    if (i == array.Length - 1) Console.Write($"{array[i]}");
    else Console.Write($"{array[i]}; ");
  }
  Console.Write($")");
}

