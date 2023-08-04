// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int size = 5;
int[,] array = new int[size, size];
Spiral(array, size);
PrintArray(array, size);

void PrintArray(int[,] array, int size)
{
    Console.WriteLine($"Массив, имеющий размер {size} x {size}, заполнен по спирали:");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            {
                Console.Write("0" + array [i, j] + " ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }
            // Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Spiral(int[,] array, int size)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while(value <= size*size)
    {
        array[i,j] = value;
        if (i <= j + 1 && i +j < size -1)
        {
            j++;
        }
        else
        {
            if (i <j && i + j >= size - 1)
            {
                i++;
            }
            else
            {
                if (i >=j && i + j > size - 1)
                {
                    j--;
                }
                else
                {
                    i--;
                }
            }
        }
         value++;
        
    }
}
