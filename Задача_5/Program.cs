// Напишите программу, которая вводит случайное число из отрезка
// [10,99] 
// И показывает наибольшую цифру числа
// 78 -> 7  8 max = 8; 78 / 10 = 7 =>78 - 10 * 7 = 8;
Console.clear;
int num = new Random().Next(10, 100);
int num1 = num / 10;
int num2 = num % 10;
int max = num1;
if (num2 > max) 
 max = num2;
Console.WriteLine($"максимальная цифра в числе {num} -> {max}");
