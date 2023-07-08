// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

void Main()
{
    int[,] matrix = FillMatrix(4, 4, 1, 9);
    PrintMatrix(matrix);
    int row = ReadInt("Введите номер строки: ");
    int col = ReadInt("Введите номер столбца: ");
    FindPosition(matrix, row, col);
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

void FindPosition(int[,] matrixToFind, int row, int col)
{
    if (row >= matrixToFind.GetLength(0) || col >= matrixToFind.GetLength(1))
    {
        System.Console.WriteLine("Нет такого элемента");
    }
    else
        for (int i = 0; i < matrixToFind.GetLength(0); i++)
        {
            for (int j = 0; j < matrixToFind.GetLength(1); j++)
            {
                if (i == row && j == col)
                    System.Console.WriteLine(matrixToFind[i, j]);
            }

        }
}