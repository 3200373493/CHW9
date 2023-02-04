// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите M = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N = ");
int n = int.Parse(Console.ReadLine());

int Sum(int F, int S)
{
    int sum = 0;
    if (F == S) return S;
    sum = F + Sum(F + 1, S);
    return sum;
}

Console.WriteLine(Sum(m, n));