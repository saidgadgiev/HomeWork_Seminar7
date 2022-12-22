/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] arr = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SummMatrix(int[,] matrix)
{
    double summ = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            summ = summ + matrix[j, i];
        }
        summ = summ / matrix.GetLength(0);
        Console.Write("{0,1:0.##}",summ);
        Console.Write("; ");
        summ = 0;
    }
}
PrintMatrix(arr);
Console.WriteLine();
SummMatrix(arr);