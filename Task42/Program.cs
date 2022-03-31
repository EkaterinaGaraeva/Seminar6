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

int[] CreatingRotatedArray(int number, int length)
{
    int[] ArrayOfNumbers = new int[length];
    for (int i = 0; i < length; i++)
    {
        ArrayOfNumbers[i] = number % 2;
        number /= 2;
    }
    return ArrayOfNumbers;
}

int[] RotateArray(int[] inputArray)
{
    int[] returningArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        returningArray[i] = inputArray[inputArray.Length - i - 1];
    }
    return returningArray;
}

string PrintArray(int[] inputArray)
{
    string returnStr = "[";
    for (int i = 0; i < inputArray.Length; i++)
    {
        returnStr += inputArray[i];
        if (i != inputArray.Length - 1)
        {
            returnStr += ", ";
        }
    }
    returnStr += "]";
    return returnStr;
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
int[] arr = CreatingRotatedArray(num, len);
string strArray = PrintArray(arr);
Console.WriteLine(strArray);
int[] binaryNumber = RotateArray(arr);
strArray = PrintArray(binaryNumber);
Console.WriteLine(strArray);
strArray = PrintBinaryNumber(binaryNumber);
Console.WriteLine(strArray);

