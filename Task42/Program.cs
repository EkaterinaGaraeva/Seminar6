/*
Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

int ArrayLength(int number)
{
    int length = 0;
    while (number > 0)
    {
        number /= 2;
        length++;
    }
    return length;
}

int[] CreatingArray(int number, int length)
{
    int[] arrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayOfNumbers[arrayOfNumbers.Length - i - 1] = number % 2;
        number /= 2;
    }
    return arrayOfNumbers;
}

string PrintBinaryNumber(int[] inputArray)
{
    string returnStr = "Двоичное число = ";
    for (int i = 0; i < inputArray.Length; i++)
    {
        returnStr += inputArray[i];
        
    }
    return returnStr;
}

Console.Write("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int len = ArrayLength(num);
int[] arr = CreatingArray(num, len);
string strArray = PrintBinaryNumber(arr);
Console.WriteLine(strArray);

