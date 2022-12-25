// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] maxtrix = new int [3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i, j] = new Random().Next(0, 20);
        }
    }
}

FillArray (maxtrix);
PrintArray(maxtrix);

Console.Write("Среднее арифметическое каждого столбца: ");

FillArray(maxtrix);
for (int j = 0; j < maxtrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < maxtrix.GetLength(0); i++)
    {
        avarage = (avarage + maxtrix[i,j]);
    }
    avarage = avarage / 4;
    Console.Write(avarage + "; ");
}