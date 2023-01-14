// Задача 8
/*
  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
  5 -> 2, 4
  8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1)
{
  Console.WriteLine($"Вce четные числа от 1 до {num}:");
  for (int i = 1; i <= num; i++)
  {
    if (i % 2 != 0) continue;
    else Console.WriteLine(i);
  }
}
else if (num < 1)
{
  Console.WriteLine($"Все четные числа от 1 до {num}:");
  for (int i = 1; i >= num; i--)
  {
    if (i % 2 != 0) continue;
    else Console.WriteLine(i);
  }
}
else if (num == 1)
{
  Console.WriteLine($"Вы ввели число {num}, от 1 до числа {num} четные числа не обнаружены");
}