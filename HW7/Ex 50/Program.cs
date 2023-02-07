// Задача 50: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
System.Console.WriteLine("Введите значение :");
int number = Convert.ToInt32(Console.ReadLine());

var arr = Generate2DArray(3, 4);
Print2DArray(arr);
FindElement(arr, number);

void FindElement(int[,] findElement, int userNumber)
{
    bool find = false;
    for(int i =0; i < findElement.GetLength(0); i++)
    {
        for(int j = 0; j < findElement.GetLength(1); j++)
        {
            if (findElement [i , j] == userNumber)
            System.Console.WriteLine("Значение находится на позиции " + i + " " + j);
            find = true;
        }
    }
    if (!find) 
    System.Console.WriteLine("Такого значения в массиве нет");
    
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i =0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1,10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }

}
