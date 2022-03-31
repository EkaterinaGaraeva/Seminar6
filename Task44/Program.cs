/*
Задача 44: Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int[] Fibonacci(int length)
{
    int[] arrayOfNumbers = new int[length];
    arrayOfNumbers[0] = 0;
    arrayOfNumbers[1] = 1;
    if (length >= 2)
    {
        for (int i = 2; i < length; i++)
        {
            arrayOfNumbers[i] = arrayOfNumbers[i - 1] + arrayOfNumbers[i - 2];
        }
    }
    return arrayOfNumbers;
}

string PrintFibonacci(int[] arrayOfNumbers)
{
    string returnStr = "Первые N чисел Фибоначчи: ";
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        returnStr += arrayOfNumbers[i];
        if (i != arrayOfNumbers.Length - 1)
        {
            returnStr += " ";
        }
    }
    return returnStr;
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] fib = Fibonacci(N);
string strFibonacci = PrintFibonacci(fib);
Console.WriteLine(strFibonacci);
