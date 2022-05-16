/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


int N = 0;
int Result;
int DigNumber;
int Pow10;
string s = "";

do
{
    Result = -1;
    Console.Clear();
    Console.WriteLine("Для выхода нажмите 'q'.");
    Console.WriteLine("Введите число:");
    s = Console.ReadLine();

    if (s == "q")
    {
        break;
    }

    N = Convert.ToInt32(s);

    for (Pow10 = 1, DigNumber = 0; (N > Pow10) || (N < -Pow10); Pow10 = Pow10 * 10, DigNumber++);

    if (DigNumber > 2)
    {
        Pow10 = Pow10 / 1000; // так как Pow10 у нас на 1 разряд больше, поэтому не на 100, а на 1000 
                              // или Result = N / Convert.ToInt32(Math.Pow(10, DigNumber-3));
        Result = N / Pow10;
        Result = Result % 10;
        if (Result < 0)
        {
            Result = -Result; // если N было отрицательным
        }
        Console.WriteLine($"В числе {N} количество цифр = {DigNumber}, третья цифра = {Result}");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine($"В числе {N} нет третьей цифры!");
        Console.ReadKey();
    }

} while (true);
