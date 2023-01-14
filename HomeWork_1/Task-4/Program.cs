// Задача 4
/*
  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
  2, 3, 7 -> 7
  44 5 78 -> 78
  22 3 9 -> 22
*/

Console.WriteLine("Введите первое целое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число:");
int number_3 = Convert.ToInt32(Console.ReadLine());

int number_max_1 = Math.Max(number_1, number_2);
int number_max_2 = Math.Max(number_2, number_3);

Console.WriteLine($"Максимальное число из введеных: {Math.Max(number_max_1, number_max_2)}");
