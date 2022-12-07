/*
Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Какой день недели интересует?");
int day = int.Parse(Console.ReadLine());
switch(day)
{
    case 1:
    Console.WriteLine("Понедельник.");
    break;

    case 2:
    Console.WriteLine("Вторник.");
    break;

    case 3:
    Console.WriteLine("Среда.");
    break;

    case 4:
    Console.WriteLine("Четверг.");
    break;

    case 5:
    Console.WriteLine("Пятница.");
    break;

    case 6:
    Console.WriteLine("Суббота - выходной, детка!");
    break;

    case 7:
    Console.WriteLine("Понедельник - отдыхаем! ");
    break;

    default:
    Console.WriteLine("Хмм, а тебя, точно Российская неделя интересует?");
    break;
}