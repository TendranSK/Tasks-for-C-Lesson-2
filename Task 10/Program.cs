// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int value = Convert.ToInt32(Console.ReadLine());
int digit = 0;

digit = value/10;
if(value < 1000){
if( digit < 10 ) Console.WriteLine("Данное число не является трёхзначным!");

if( digit > 10 ) {

    digit = digit%10;
    Console.WriteLine("{0} - вторая цифра числа {1}", digit , value);
}
}
if (value >= 1000)Console.WriteLine("Данное число не является трёхзначным!");