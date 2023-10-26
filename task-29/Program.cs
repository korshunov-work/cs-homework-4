void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
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
int arraySize = Math.Abs(CheckInputInt32("Введите размер массива:"));
int minValue = CheckInputInt32("Введите минимальное значение элемента массива:");
int maxValue = CheckInputInt32("Введите максимальное значение элемента массива:");
int[] userArray = GetRandomArray(arraySize, minValue, maxValue);
PrintArray(userArray);