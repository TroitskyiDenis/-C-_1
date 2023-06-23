//***Задача 0:***

//**Условие:**

// Напишите программу, которая на вход принимает число и выдает его квадрат(число умноженное на само себя).

// Например:

// 4 -> 16
// -3 -> 9 */
Console.Clear();
Console.WriteLine("Ввидите число a:");
int a = int.Parse(Console.ReadLine());
//Первый метод
int result1 = a*a;
Console.WriteLine($"Способ 1 -> Квадрат числа {a} равен {result1}");
//Второй метод
int result2 = Convert.ToInt32(Math.Pow(a,2));
Console.WriteLine($"Способ 1 -> Квадрат числа {a} равен {result1}");
