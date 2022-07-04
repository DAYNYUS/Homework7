/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArrayRandomNumbers(array);
PrintArray(array);


for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += array[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.Write($"Cреднее арифметическое: ");
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
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
