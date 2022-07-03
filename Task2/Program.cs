/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
/*
 Console.Write("Введите строку:");
            int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Введите столбец:");
            int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
            int n = 5; // размер массива
            int m = 7; // размер массива
            Random random = new Random();
            int[,] arr = new int[n, m];
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(10, 99);
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
            {
                Console.WriteLine("Элемент не существует");
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
            }
            Console.ReadLine();*/

Console.WriteLine("Введите количество строк m: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов n: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];


Console.Write("Введите строку:");
int row = Convert.ToInt32(Console.ReadLine())-1;

Console.Write("Введите столбец:");
int col = Convert.ToInt32(Console.ReadLine())-1;

FillArrayRandomNumbers(array);
PrintArray(array);

if (row < 0 | row > array.GetLength(0) - 1 | col < 0 | col > array.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine($"Значение элемента массива = {array[row, col]}");
}


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 99);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

  


