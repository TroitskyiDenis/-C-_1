// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5,25-> да
//-4,16 -> да
// 8,9 -> нет
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());;
if(Math.Pow(a,2) == b || a == b * b)
{
Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

