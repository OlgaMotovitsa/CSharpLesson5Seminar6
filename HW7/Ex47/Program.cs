// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

var arr = Generate2DArray(3, 4);
Print2DArray(arr);

double[,] Generate2DArray(int m, int n)
{
    double[,] result = new double[m, n];

    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
                      // = new Random().Next(-100, 101)/ 10.0;

            result[i, j] = Math.Round (new Random().Next(-100, 101)* 0.1 , 1);                            
        }
    }
    return result;
}
static void Print2DArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t" );
        }
        System.Console.WriteLine();
    }
}