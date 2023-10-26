int GetDigitSum(int number)
{
    number = Math.Abs(number);
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
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

Console.Clear();
int userNumber = CheckInputInt32("Введите целое число:");
Console.WriteLine($"Сумма цифр числа {userNumber} равна {GetDigitSum(userNumber)}.");