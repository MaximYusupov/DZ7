// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] maxtrix = new int[5, 5];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

FillArray(maxtrix);

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

if (n > maxtrix.GetLength(0) || m > maxtrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine("значение элемента равно = " + maxtrix[n - 1, m - 1]);
}

PrintArray(maxtrix);