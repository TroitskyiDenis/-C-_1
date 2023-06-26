// Напишите программу, которая будет принимать на вход два числа и выводить, 
?\//является ли второе число кратным первому. Если второе число не кратно числу первому,
//то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
Console.Clear();

Console.Write("Введите число 1 -> ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2 -> ");
int num2 = int.Parse(Console.ReadLine());

int result = num1 % num2;

if (result == 0)
{
    Console.Write($"Число {num1} кратно числу {num2}");
}
else
{
    Console.Write($"Число {num1} не кратно числу {num2}, остаток равен {result}");
}
