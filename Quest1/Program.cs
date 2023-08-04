// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");

int[,] matrix = GetArray(rows, columns);

PrintArray(matrix);

matrix = Order(matrix);
Console.WriteLine();
PrintArray(matrix);

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
            res[i, j] = new Random().Next(1, 100);
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

int[,] Order(int[,] array)
{
    int a = 0;
    for(int k=0; k<array.GetLength(0); k++) //строка
    {
        //Сортировка строки
        for (int i = 0; i < array.GetLength(1); i++) //столбцы
        {
            for (int j = i+1; j < array.GetLength(1); j++) //столбцы
            {
                if(array[k,i] < array[k,j])
                {
                    a = array[k,i];
                    array[k,i] = array[k,j];
                    array[k,j] = a;
                }
            }
        }
    }
  return array;
}