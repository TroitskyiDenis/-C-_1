Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Выражение из if {Math.Pow(b,2) == a}");
if(Math.Pow(b,2) == a)
{
    Console.WriteLine("a квадрат b");
}else
{
Console.WriteLine("a не квадрат b");
}


