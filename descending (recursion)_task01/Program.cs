/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int Descending (int n)
{
    
    if(n < 1 ) return -1;
    Console.WriteLine(n);
    return Descending(n -1);
}

int Prompt(string massage)
{
    Console.WriteLine(massage);
    string string_input = Console.ReadLine()!;
    int result = int.Parse(string_input);
    return result;
}

int number = Prompt("Введите натуральное число");

if(number < 1)
{
    Console.WriteLine("число не является натуральным, пожалуйста, повторите запуск ");
}
else
{
    Descending(number);
}