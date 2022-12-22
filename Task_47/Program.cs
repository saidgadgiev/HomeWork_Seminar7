/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumber(string messege)
{
    int resultat;
    while (true)
    {
        Console.Write(messege);
        if (int.TryParse(Console.ReadLine(), out resultat) && resultat > 0)
        {
            break;
        }
        else Console.WriteLine("Ввели не число");
    }
    return resultat;
}

void InitArray(int rows, int col)
{
    double[,] matrix = new double[rows, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Convert.ToDouble(rnd.Next(-100,100)/10.0);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}

int rows = GetNumber("Введите количество строк > ");
int col = GetNumber("Введите количество столбцов - > ");
InitArray(rows, col);