/*
Задача 40: Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой 
длины.
Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.
*/

void Triangle(int firstSide, int secondSide, int thirdSide)
{
    if (firstSide < secondSide + thirdSide && secondSide < firstSide + thirdSide && thirdSide < firstSide + secondSide)
    {
        Console.WriteLine($"Треугольник со сторонами {firstSide}, {secondSide}, {thirdSide} может существовать");
    }
    else
    {
        Console.WriteLine($"Треугольник со сторонами {firstSide}, {secondSide}, {thirdSide} не может существовать");
    }
}

Console.Write("Введите длину первой стороны: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей стороны: ");
int side3 = Convert.ToInt32(Console.ReadLine());

Triangle(side1, side2, side3);
