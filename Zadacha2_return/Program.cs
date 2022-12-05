try
{
    Console.WriteLine("Введите координату х");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y");
    int y = Convert.ToInt32(Console.ReadLine());
    CheckKoord(x, y);
    Console.WriteLine(CheckKoord2(x, y));
}
catch
{
    Console.WriteLine("Надо вводить целые числа");
}
void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Это четверть №1");
    else if (x > 0 && y < 0)
        Console.WriteLine("Это четверть №4");
    else if (x < 0 && y > 0)
        Console.WriteLine("Это четверть №2");
    else if (x < 0 && y < 0)
        Console.WriteLine("Это четверть №3");
    else
        Console.WriteLine("точка находится на координатной оси");
}
string CheckKoord2(int x, int y)
{
    string res;
    if (x > 0 && y > 0)
        res = "Это четверть №1";
    else if (x > 0 && y < 0)
        res = "Это четверть №4";
    else if (x < 0 && y > 0)
        res = "Это четверть №2";
    else if (x < 0 && y < 0)
        res = "Это четверть №3";
    else
        res = "точка находится на координатной оси";
    return res;
}