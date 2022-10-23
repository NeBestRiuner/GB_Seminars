//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int ToPower(int bod, int exp)
{
    int i=1;
    int N=bod;
    while(i<exp)
    {
        N=N*bod;
        i++;
    }
    return N;
}
Console.WriteLine("Введите основание степени: А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое будет степенью: B");
int b = Convert.ToInt32(Console.ReadLine());
int result = ToPower(a,b);
Console.WriteLine($"Итог: {result}");
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigit(int num)
{
    int dig;
    int sum=0;
    while(num!=0)
    {
        dig = num%10;
        num/=10;
        sum=sum+dig;
    }
    return sum;
}
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumDigit(num);
Console.WriteLine($"Сумма цифр в числе {num} - это {result}");
*/
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] Array8(int a, int b, int c, int d, int f, int g, int h, int j)
{
    int [] Arr = new int[8];
    Arr[0] = a;
    Arr[1] = b;
    Arr[2] = c;
    Arr[3] = d;
    Arr[4] = f;
    Arr[5] = g;
    Arr[6] = h;
    Arr[7] = j;
    return Arr;
}
void PrintArr(int[] Arr)
{
    Console.Write($"[ {Arr[0]} ,");
    int i = 1;
    while(i<7)
    {
    Console.Write($" {Arr[i]},");
    i++;
    }
    Console.WriteLine($" {Arr[7]}]");
}
Console.WriteLine($"Введите 1 элемент массива:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите 2 элемент массива:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите 3 элемент массива:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите 4 элемент массива:");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите 5 элемент массива:");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите 6 элемент массива:");
int g = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите 7 элемент массива:");
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите 8 элемент массива:");
int j = Convert.ToInt32(Console.ReadLine());
int[] result = Array8(a,b,c,d,f,g,h,j);
PrintArr(result);
