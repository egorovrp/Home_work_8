// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int rows1 = GetNum("Введите количество строк 1й матрицы: ");
int columns1 = GetNum("Введите количество столбцов 1й матрицы: ");
int rows2 = GetNum("Введите количество строк 2й матрицы: ");
int columns2 = GetNum("Введите количество столбцов 2й матрицы: ");


int[,] matrix1 = GetArray(rows1, columns1);
int[,] matrix2 = GetArray(rows2, columns2);
Console.WriteLine("Первая матрица:");
PrintArray(matrix1);
Console.WriteLine("Вторяая матрица:");
PrintArray(matrix2);

if(matrix1.GetLength(0) == matrix2.GetLength(1))
{
   int [,] result = MultipliMatrix(matrix1, matrix2);
   Console.WriteLine("Результирующая матрица:");
   PrintArray(result);
}
else
{
    Console.Write("Невозможно выполнить перемножение: неверный формат матриц!");
}


int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int row, int column)
{
    int[,] res = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            res[i, j] = new Random().Next(1, 10);
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultipliMatrix(int[,] array1, int[,] array2)
{
        int[,] arr = new int[array1.GetLength(0), array2.GetLength(1)];
        
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    arr[i,j] += array1[i,k]*array2[k,j];
                }
            }
        }
    return arr;
}