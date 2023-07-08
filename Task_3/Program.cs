// Задача 52.
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void Main()
{
    int row = ReadInt("Введите количество строк в массиве: ");
    int col = ReadInt("Введите количество столбцов в массиве: ");
    int[,] matrix = FillMatrix(row, col, 1, 9);
    PrintMatrix(matrix);
    Console.WriteLine();
    AverageColumn(matrix, out double avCol);
    Console.WriteLine();

}

Main();

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrixToPrint)
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

double AverageColumn(int[,] matrixToFind, out double avCol)
{
    avCol = 0;
    for (int j = 0; j < matrixToFind.GetLength(1); j++)
    {
        avCol = 0;
        for (int i = 0; i < matrixToFind.GetLength(0); i++)
        {
            if (j < matrixToFind.GetLength(1))
            {
                avCol = avCol + matrixToFind[i, j];
            }
            System.Console.Write(avCol / matrixToFind.GetLength(1) + "\t");
        }
        return avCol;
    }
    return avCol;
}