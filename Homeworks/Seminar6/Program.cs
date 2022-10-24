// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int [] CreateArr(int ArrLen)
{
    int[] Arr = new int[ArrLen];
    int i = 0;
    while(i<ArrLen)
    {   
        Console.WriteLine($"Введите {i+1} число:");
        Arr[i]= Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return Arr;
}
void ShowArr(int[] Arr)
{
    Console.Write($" {Arr[0]} ,");
    int i = 1;
    while(i<Arr.Length-1)
    {
        Console.Write($" {Arr[i]} ,");
        i++;
    }
    Console.WriteLine($" {Arr[i]} ");
}
int PositiveCount(int[] Arr)
{
    int Count=0;
    int i =0;
    while(i<Arr.Length)
    {
        if(Arr[i]>0)
        {
            Count++;
        }
        i++;
    }
    return Count;

}
Console.WriteLine("Введите количество чисел:"); 
int Len = Convert.ToInt32(Console.ReadLine());
int[] Arr = CreateArr(Len);
int Result = PositiveCount(Arr);
ShowArr(Arr);
Console.WriteLine($"Количества чисел больше 0 = {Result}");
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double [] CrossPoint(int k1, int b1, int k2, int b2)
{
    double[] Arr = new double[2];
    double x = (double)(b1-b2)/(k2-k1);
    Arr[0]=x;
    double y = k1*x+b1;
    Arr[1]=y;
    return Arr;
}
Console.WriteLine("Для первого уравнения прямой y=k1x+b1\n Введите k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Для первого уравнения прямой y=k1x+b1\n Введите b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Для второго уравнения прямой y=k2x+b2\n Введите k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Для второго уравнения прямой y=k2x+b2\n Введите b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
double[] Result = CrossPoint(k1,b1,k2,b2);
Console.WriteLine($"Точка пересечения двух заданных прямых: ({Result[0]},{Result[1]})");