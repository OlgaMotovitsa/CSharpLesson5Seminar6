// Напишите программу, которая принимает на вход 3 числа и проверяет,
// может ли существовать треугольник со сторонами такой длины

// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы 2х других сторон


// System.Console.WriteLine("Поэтапно введите 3 числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// bool CompareNum(int num1, int num2, int num3)
// {
//     if (num1 > num2 + num3)
//     {
//         return false;
//     }

//     else  if (num2 > num1 + num3)
//     {
//         return false;
//     }

//     else  if (num3 > num1 + num2)
//     {
//         return false;
//     }

//     else 
//     {
//         return true;
//     }

// }

// System.Console.WriteLine(CompareNum(num1, num1, num3));




bool CompareNum(int num1, int num2, int num3)
{
   return(((num1 + num2) > num3) 
            && ((num1 + num3) > num2) 
            && ((num2 + num3)> num1));
}

System.Console.WriteLine(CompareNum(-6, 5, 7));



