//Напишите программу,которая принимает на вход число (N),
// и выдает таблицу квадратов от 1 до N.

Console.Clear();
Console.WriteLine("Введите n ");
int n = int.Parse(Console.ReadLine());
int i = 1;
int a = 1;
while ( i<= n)
{
    a = i*i;
    Console.WriteLine(a);
    i++;
}