// Задача 15
/*
  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет
*/

Console.WriteLine("Введите число, соответствующее дню недели");
int numberDay = Convert.ToInt32(Console.ReadLine());

switch (numberDay)
{
  case 1: Console.WriteLine($"Сегодня понедельник, рабочий день!"); break;
  case 2: Console.WriteLine($"Сегодня вторник, рабочий день!"); break;
  case 3: Console.WriteLine($"Сегодня среда, рабочий день!"); break;
  case 4: Console.WriteLine($"Сегодня четверг, рабочий день!"); break;
  case 5: Console.WriteLine($"Сегодня пятница, рабочий день!"); break;
  case 6: Console.WriteLine($"Сегодня суббота, выходной день!"); break;
  case 7: Console.WriteLine($"Сегодня воскресение, выходной день!"); break;
  default: Console.WriteLine("Ни один день недели не обозначается введенным вами числом"); break;
}
