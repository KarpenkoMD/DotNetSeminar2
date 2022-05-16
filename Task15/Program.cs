/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int N;
string s="";
string[] WeekDays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
do
{
    N=0;
    Console.Clear();
    Console.WriteLine("Для выхода нажмите 'q'.");
    Console.WriteLine("Введите день недели:");
    s = Console.ReadLine();

    if (s == "q")
    {
        break;
    }

    N = Convert.ToInt32(s);

    if ((N > 8) || (N < 0))
    {
        Console.WriteLine($"Номер дня в неделе не может быть {N}.");
        Console.ReadKey();
    }
    else if (N < 6 )
    {
        Console.WriteLine($"Сегодня {WeekDays[N-1]}, иди работай!");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine($"Сегодня {WeekDays[N-1]}, выходной!");
        Console.ReadKey();
    }

} while (true);


