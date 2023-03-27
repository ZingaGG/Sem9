/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int TakeDigit(string a)
{
    System.Console.WriteLine(a);
    int result = Int32.Parse(System.Console.ReadLine());
    return result;
}

void NumFromNto1(int n)
{
    if (n==1)
    {
        System.Console.WriteLine("n = 1");
    }
    else
    {
        System.Console.WriteLine($"n = {n}");
        NumFromNto1(n-1);
    }
}

// task 1
/*
int n = TakeDigit("Input n = ");
NumFromNto1(n);
*/


/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumFromMtoN(int n, int m)
{
    int result = 0;

    if(m==n)
    {
        return result;
    }
    else
    {
        result += m + SumFromMtoN(n, m+1);
        return result;
    }
}

// Task 2
/*

int m = TakeDigit("Input m = ");
int n = TakeDigit("Input n = ");

if(n<m)
{
    int temp = m;
    m = n;
    n = temp;
}

System.Console.WriteLine("Sum = " + SumFromMtoN(n,m));
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9 
*/

int LevaAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return LevaAckerman(m - 1, 1);
    }
    else
    {
        return LevaAckerman(m - 1, LevaAckerman(m, n - 1));
    }
}

int m = TakeDigit("Input m = ");
int n = TakeDigit("Input n = ");
System.Console.WriteLine(LevaAckerman(m,n));