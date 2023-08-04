// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");

int[,] matrix = GetArray(rows, columns);

PrintArray(matrix);

int[] Result = Sum(matrix);
// PrintArray1(Result);

SearchMin(Result);

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
    for (int i = 0; i < array.GetLength(0); i++) //строка
    {
        for (int j = 0; j < array.GetLength(1); j++) //столбец
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// void PrintArray1(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         Console.Write($"{array[i]} ");
//     }
        
    
// }

int [] Sum (int[,] array)
{
    int [] arr = new int [array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[i] = array[i,j] + arr[i];
        }
    }
    return arr;
}

void SearchMin(int[] array)
{
    int Min = array[0];
    int MinI = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (Min>array[i])
        {
            Min = array[i];
            MinI = i+1;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {MinI} строка (Сумма = {Min})");
}