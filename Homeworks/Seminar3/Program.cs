//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrom(int num)
{
    if((num%10==num/10000)&&((num%100)/10==(num/1000)%10))
    {
        return true;
    }
    else return false;
}
Console.WriteLine("Введите пятизначное число:");
int numb = Convert.ToInt32(Console.ReadLine());
bool result = Palindrom(numb);
if(result==true) Console.WriteLine("Оно палиндром");
else Console.WriteLine("Оно не палиндром");
*/
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double length(double[] Point1, double[] Point2)
{
    return Math.Sqrt(Math.Pow(Point1[0]-Point2[0],2.0)+Math.Pow(Point1[1]-Point2[1],2.0)+Math.Pow(Point1[2]-Point2[2],2.0));
}
int i = 0;
int d = 1;
double [] Point1 = new double[3];
double [] Point2 = new double[3];
while(d!=3)
{
    while(i!=3){
        if(d==1)
        {
        Console.WriteLine($"Введите {i+1} координату точки А:");
        } 
        else Console.WriteLine($"Введите {i+1} координату точки B:");
        if(d==1)
        {
            Point1[i] = Convert.ToDouble(Console.ReadLine());
        }
        else Point2[i] = Convert.ToDouble(Console.ReadLine());
        i++;
    }
    i = 0;
    d++;
}
double result = length(Point1,Point2);
Console.WriteLine($"Расстояние между точками A и B: {result}");
*/
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void Table(int num)
{
    int i = 1;
    while (i<num)
    {
        Console.Write($"{Math.Pow(i,2.0)} , ");
        i++;
    }
    Console.WriteLine($"{Math.Pow(i,2.0)}");
}
Console.WriteLine("Введите число, для которого нужно выдать таблицу кубов:");
int result = Convert.ToInt32(Console.ReadLine());
Table(result);