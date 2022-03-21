// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber<8 && dayNumber>0)
    switch(dayNumber){
        case 1: Console.WriteLine("Понедельник. Рабочий день.");
            break;
        case 2: Console.WriteLine("Вторник. Рабочий день.");
            break;
        case 3: Console.WriteLine("Среда. Рабочий день.");
            break;
        case 4: Console.WriteLine("Четверг. Рабочий день.");
            break;
        case 5: Console.WriteLine("Пятница. Рабочий день.");
            break;
        case 6: Console.WriteLine("Суббота. Выходной.");
            break;
        case 7: Console.WriteLine("Воскресенье. Выходной.");
            break;
    }
else Console.WriteLine("Нужно ввести цифру, обозначающую день недели!");
