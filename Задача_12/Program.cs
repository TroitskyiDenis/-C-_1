﻿// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3

//78 -> 2

//89126 -> 5
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());


int Numbers(int number){
    int count = 0;
    if(number == 0){
        count = 1;
    }
    else{
        
        while(number > 0){
            number /= 10;
            count++;
        }
    }

    return count;
}
Console.WriteLine($"{num} -> {Numbers(num)}");
