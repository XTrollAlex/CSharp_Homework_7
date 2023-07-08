// Задача 47.
// Задайте двумерный массив размером m×n,заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2    -0,2
// 1   -3,3   8    -9,9
// 8    7,8  -7,1   9


void Main()
{
    int row = ReadInt("Введите количество строк в массиве: ");
    int col = ReadInt("Введите количество столбцов в массиве: ");
    double[,] array = FillMatrix(row, col, -10, 10);
    PrintMatrix(array);
}

Main();

double[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    double[,] tempMatrix = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            tempMatrix[i, j] = Math.Round(leftRange + rand.NextDouble() * (rightRange - leftRange), 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matrixToPrint)
{
    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}