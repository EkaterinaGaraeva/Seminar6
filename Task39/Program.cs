/*
Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] GenerateArray(int length, int maxValue)
{
    int[] returningArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        returningArray[i] = new Random().Next(0, maxValue+1);
    }
    return returningArray;
}

int[] rotateArray(int[] inputArray)
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

int[] arrayToRotate = GenerateArray(10, 10);
int[] rotatedArray = rotateArray(arrayToRotate);
int[] rotatedRotatedArray = rotateArray(rotatedArray);
Console.WriteLine("Сгенерированный массив:");
string strArray = PrintArray(arrayToRotate);
Console.WriteLine(strArray);
Console.WriteLine();
Console.WriteLine("Перевернутый массив:");
strArray = PrintArray(rotatedArray);
Console.WriteLine(strArray);
Console.WriteLine();
Console.WriteLine("Перевернутый еще раз массив:");
strArray = PrintArray(rotatedRotatedArray);
Console.WriteLine(strArray);
Console.WriteLine();
