/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int N = 0;
int Result = -1;
string s = "";
do
{
    Console.Clear();
    Console.WriteLine("Для выхода нажмите 'q'.");
    Console.WriteLine("Введите трехзначное число:");
    s = Console.ReadLine();

    if (s == "q")
    {
        break;
    }

    N = Convert.ToInt32(s);

    if ((N > 99) & (N < 1000))
    {
        Result = N % 100;
        Result = Result / 10;
        Console.WriteLine($"В трехзначном числе {N} вторая цифра - {Result}");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Число не трехзначное!");
        Console.ReadKey();
    }

} while (true);

