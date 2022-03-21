// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int value = Convert.ToInt32(Console.ReadLine());
int temp = value;
int digit = 0;
if (value >99 ){

    while(temp >99){
    
        digit = temp%10;
        temp = temp/10;

    }

    Console.WriteLine("{0} - третья цифра числа {1}",digit, value);

}

else Console.WriteLine("{0} - не имеет 3-ей цифры",value);

//работает на все положительные числа