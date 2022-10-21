
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int a)
{
    int second = (a%100)/10;
    return second;
}
int rnd = new Random().Next(100,1000);
int result = SecondDigit(rnd);
Console.WriteLine($"Вторая цифра в числе {rnd}, это - {result}.");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int num)
{
    if(num<100)
    {
        return 13;
    }
    else
    {
        int third = (num%1000)/100;
        return third;
    }
}
int rnd = new Random().Next();
int result = ThirdDigit(rnd);
if(result!=13)
{
Console.WriteLine($"Третья цифра числа {rnd} - это {result}");
}
else
{
    Console.WriteLine($"В числе {rnd} третьей цифры нет");
}
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool WeekDay(int num)
{
    if((num%7==0)||(num%6==0))
    {
        return true;
    }
    else return false;
}
int rnd = new Random().Next(0,100);
Console.WriteLine($"{rnd}");
bool result = WeekDay(rnd);
if(result==true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}