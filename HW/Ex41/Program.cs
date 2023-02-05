// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

System.Console.Write("Введите количество Элементов в создаваемом массиве:\t");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];

    for (int i = 0; i < myArray.Length; i++)
    {
       System.Console.WriteLine($"Введите элемент массива под индексом {i}: \t ");
       myArray[i] = int.Parse(Console.ReadLine());
    }

System.Console.WriteLine("Вывод массива");

    for (int i = 0; i < myArray.Length; i++)
    {
       System.Console.Write(myArray[i] + " "); 
    }

   System.Console.Write("Всего положительных чисел: ");
   System.Console.WriteLine(FindPozitiveNum(myArray));
   
   int FindPozitiveNum(int [] array)
   {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >=0)
        {
            count ++;
        }
    }
    return count;
   }
  





// PrintArray(arr);
// //PrintArray(arr);


// int[] CopyArray(int[] arr)
// {
//     int[] result = new int[arr.Length];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         result[i] = arr[i];
//     }
//     return result;
// }


// int[] GetRandomArray(int length)
// {
//     int[] result = new int[length];

//     for (int i = 0; i < length; i++)
//     {
//         result[i] = new Random().Next(1, 10);
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     foreach (int item in arr)
//     {
//         Console.Write(item + " ");
//     }
//     System.Console.WriteLine();
// }