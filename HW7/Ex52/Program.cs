// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[n, m];

Generate2DArray(arr);
PrintArray(arr);
Console.Write("Среднее арифметическое каджого столбца : ");
System.Console.WriteLine();
GetAverageResult(arr);


void GetAverageResult(int[,] numbers)
{

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double result = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            result = (result + numbers[i, j]);
        }
        result = result / n;
        Console.Write(result + "; ");
    }
}

void Generate2DArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}