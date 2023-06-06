/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int NaturalNumberRec(int m, int n)
{
if(m >= n) return m;
return m + NaturalNumberRec(m + 1, n);
}

int Prompt(string massage)
{
    Console.WriteLine(massage);
    string string_input = Console.ReadLine()!;
    int result = int.Parse(string_input);
    return result;
}

int m = Prompt("Введите число  \"M\"");
int n = Prompt("Введите число  \"N\"");
if(m < 0 || n < 0 )
{
    Console.WriteLine("Неверный ввод");
}
else
{
    int overDigitsInString = NaturalNumberRec(m, n);
    Console.WriteLine($"Cумма всех елементов в промежутке от M до N = {overDigitsInString}");
}






