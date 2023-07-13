// // **Задача 42:**Напишите программу,
    //  которая будет преобразовывать десятичное число в двоичное.

    // 45 -> 101101

    // 3 -> 11

    // 2 -> 10
Console.Clear();

int number = int.Parse(Console.ReadLine());
int sysTem = int.Parse(Console.ReadLine());
string res = DecToNum(number, sysTem);

Console.WriteLine($"{number}->{res}");


//Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";// nums[3 % 2] "asdf" a % 2 == 1 || 0
    //             0123456789(10 = A)(11=B)(12=C)(13=D)(14=E)(15=F)
    while (decNumber > 0)//decNumber = 1    res = "1011"   decNumber%otherSystem = 2 % 2
    {
        //  "1"                   + "011"
        // a = a + b
        // a = b + a

        res = nums[decNumber%otherSystem] + res;//res += nums[decNumber%otherSystem]
        //res = (decNumber % otherSystem).ToString() + res;
        decNumber /= otherSystem; // decNumber = decNumber/ otherSystem
    }
    return res;
}
