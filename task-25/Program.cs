double Exp(double number, int degree)
{
    if (degree >= 0)
    {
        double result = 1;
        for (int i = 0; i < degree; i++)
        {
            result *= number;
        }
        return result;
    }
    else
    {
        degree = -degree;
        double result = 1;
        for (int i = 0; i < degree; i++)
        {
            result *= number;
        }
        return (1 / result);
    }
}

int CheckInputInt32(string message)
{
    bool check = false;
    int number;
    Console.Write($"{message} ");
    check = int.TryParse(Console.ReadLine(), out number);
    while (check == false)
    {
        Console.Write($"Неверные данные. {message} ");
        check = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}

double CheckInputDouble(string message)
{
    bool check = false;
    double number;
    Console.Write($"{message} ");
    check = double.TryParse(Console.ReadLine()?.Replace(",", "."), out number);
    while (check == false)
    {
        Console.Write($"Неверные данные. {message} ");
        check = double.TryParse(Console.ReadLine(), out number);
    }
    return number;
}

Console.Clear();
double userNumber = CheckInputDouble("Введите число:");
int userDegree = CheckInputInt32("Введите степень числа:");
Console.WriteLine($"Число {userNumber} в степени {userDegree} равно: {Exp(userNumber, userDegree)}");