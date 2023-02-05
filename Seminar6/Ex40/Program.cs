//  Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые 2 числа Фибоначчи 0 и 1.
// Если N = 7 -> 0 1 1 2 3 4 8 
// Если N = 3 -> 0 1 1
// Если N = 5 -> 0 1 1 2 3

// f(n) = f(n-1) + f(n-2)

int firstNum = 0;
int secondNum = 1;
int n =10;

System.Console.WriteLine(firstNum);
System.Console.WriteLine(secondNum);

for(int i = 3; i <= n; i++)
{
    int currentNum = secondNum + firstNum;
    System.Console.WriteLine(currentNum);

    firstNum = secondNum;
    secondNum = currentNum;

}
