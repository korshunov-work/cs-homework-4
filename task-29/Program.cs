void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

int[] GetRandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1000);
    }
    return array;
}

int[] userArray = GetRandomArray();

PrintArray(userArray);