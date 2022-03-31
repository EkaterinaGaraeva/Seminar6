/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/

int[] CopyArray(int[] arrayOfNumbers)
{
    int[] copy = new int[arrayOfNumbers.Length];
    for (int i = 0; i < arrayOfNumbers.Length; i++)
    {
        copy[i] = arrayOfNumbers[i];
    }
    return copy;
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

int[] arr = {0, 1, 8, 3, 4, 5};
string strCopyArray = PrintArray(arr);
Console.WriteLine(strCopyArray);
Console.WriteLine();


int[] copy = CopyArray(arr);
strCopyArray = PrintArray(copy);
Console.WriteLine(strCopyArray);
