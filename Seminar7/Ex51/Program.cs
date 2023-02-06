// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

var arr = Generate2DArray(3, 4);
Print2DArray(arr);
var sum = GetSum(arr);
System.Console.WriteLine();
System.Console.WriteLine(sum);

int GetSum(int[,] arr)
                    // тернарный оператор
                 // если у нас строк меньше чем столбцов то используй 0           иначе 1
{
    int length = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    int sum = 0;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, i];
    }
    return sum;
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
