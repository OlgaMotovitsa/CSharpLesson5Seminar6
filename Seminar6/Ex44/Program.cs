// Напишите программу, которая будет создавать клпию заданного массива
// с помощью поэлементного копирования


int[] arr = GetRandomArray(10);
PrintArray(arr);
PrintArray(CopyArray(arr));

int[] CopyArray(int[] arr)
{
    int[] result = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}


int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    System.Console.WriteLine();
}