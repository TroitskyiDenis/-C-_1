﻿// /11 Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98
int num = new Random().Next(100, 1000);
int result  = (num / 100) * 10 + num % 10;
Console.WriteLine($" {num} ->{result} ->{num/10%10}"); // два метода решения
Console.WriteLine($"{num} ->{num/100}{num%10}");