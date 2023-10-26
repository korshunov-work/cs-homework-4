int GetDigitSum(int number)
{
    number = Math.Abs(number);
    int result = 0;
    while(number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

Console.Clear();

bool check = false;
int userNumber;
Console.Write("Введите число: ");
check = int.TryParse(Console.ReadLine(), out userNumber);
while (check == false)
{
    Console.Write("Неверные данные. Введите число: ");
    check = int.TryParse(Console.ReadLine(), out userNumber);
}

Console.WriteLine($"Сумма цифр числа {userNumber} равна {GetDigitSum(userNumber)}.");