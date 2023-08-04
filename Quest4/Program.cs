// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int axis1 = GetNum("Введите 1е значение трехмерного массива: ");
int axis2 = GetNum("Введите 2е значение трехмерного массива: ");
int axis3 = GetNum("Введите 3е значение трехмерного массива: ");

int[,,] matrix = GetArray(axis1, axis2, axis3);

PrintArray(matrix);
CreateArray(matrix);
Console.WriteLine("-------------------------------------------------------------");
PrintArray(matrix);


int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] GetArray(int axis1, int axis2, int axis3)
{
    int[,,] res = new int[axis1, axis2, axis3];
    for (int i = 0; i < axis1; i++)
    {
        for (int j = 0; j < axis2; j++)
        {
            for(int k = 0; k < axis3; k++)
            {
                res[i, j, k] = new Random().Next(1, 100);
            }
        }
    }
    return res;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} {(i,j,k)}\t ");
            }
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] array)
{
    int[] temp = new int[array.Length];
    int number;
    for (int i = 0; i < temp.Length; i++)
    {
        temp [i] = new Random().Next(10,100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10,100);
                    j=0;
                    number = temp[i];
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for(int y = 0; y < array.GetLength(1); y++)
        {
            for(int z = 0; z < array.GetLength(2); z++)
            {
                array[x,y,z] = temp [count];
                count++;
            }
        }
    }
}