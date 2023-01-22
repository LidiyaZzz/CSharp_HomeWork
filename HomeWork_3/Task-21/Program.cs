
// Задача 21
/*
  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
  int resultNumber = 0;
  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out resultNumber))
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

double GetCoordinates(int xA, int yA, int zA, int xB, int yB, int zB)
{
  double result = Math.Round(Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2)), 2);
  return result;
}

int xA = GetNumber("Введите координату X точки A:");
int yA = GetNumber("Введите координату Y точки A:");
int zA = GetNumber("Введите координату Z точки A:");

int xB = GetNumber("Введите координату X точки B:");
int yB = GetNumber("Введите координату Y точки B:");
int zB = GetNumber("Введите координату Z точки B:");

Console.WriteLine(GetCoordinates(xA, yA, zA, xB, yB, zB));

