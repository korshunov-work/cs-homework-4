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

Console.Clear();
bool check = false;
double userNumber;
int userDegree;
Console.Write("Введите число: ");
check = double.TryParse(Console.ReadLine(), out userNumber);
while (check == false)
{
    Console.Write("Недопустимое значение. Введите число: ");
    check = double.TryParse(Console.ReadLine(), out userNumber);
}
Console.Write("Введите степень: ");
check = int.TryParse(Console.ReadLine(), out userDegree);
while (check == false)
{
    Console.Write("Недопустимое значение. Введите число: ");
    check = int.TryParse(Console.ReadLine(), out userDegree);
}

Console.WriteLine($"Число {userNumber} в степени {userDegree} равно: {Exp(userNumber, userDegree)}");