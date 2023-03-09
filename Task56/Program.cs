// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/// <summary>
/// Метод создания двумерного массива и наполнения его рандомными числами
/// </summary>
/// <param name="rows">количество строк массива</param>
/// <param name="cols">количество столбцов массива</param>
/// <param name="min">минимальное значение элемента массива</param>
/// <param name="max">максимальное значение элемента массива</param>
/// <returns>возвращает двумерный массив</returns>
int[,] GetArray(int rows, int cols, int min, int max)
{
  int[,] array = new int[rows, cols];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(min, max + 1);
    }
  }
  return array;
}
/// <summary>
/// Метод вывода массива на консоль
/// </summary>
/// <param name="arr">на вход - двумерный массив</param>
void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int[,] matrix = GetArray(3, 3, 0, 10);
PrintArray(matrix);

/// <summary>
/// Метод поиска минимальной по сумме строки двумерного массива
/// </summary>
/// <param name="matr">на вход вводится двумерный массив</param>
/// <returns>возвращается номер строки с минимальнйо суммой элементов</returns>
int FindMinSumString(int[,] matr)
{
  int[] sums = new int[matr.GetLength(0)];
  int sum = 0;
  
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      sum = sum + matr[i, j];
    }
    sums[i] = sum;
    sum = 0;
  }
  Console.WriteLine($"Суммы строк: {String.Join(" ", sums)}");
  int min = sums[0];
  int stringOfMin = 1; // "1" - номер 1 строки по умолчанию
  for (int m = 0; m < matr.GetLength(0); m++)
  {
    if (sums[m] < min)
    {
      min = sums[m];
      stringOfMin = m + 1; //+1, т.к. выдаем номер строки
    }
  }
  return stringOfMin;
}

Console.Write($"номер строки с наименьшей суммой элементов: {FindMinSumString(matrix)} строка");