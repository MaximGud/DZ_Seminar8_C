// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/// <summary>
/// метод создания двумерного массива
/// </summary>
/// <param name="rows">количество строк</param>
/// <param name="cols">количество столбцов</param>
/// <param name="min">минимальное значение элемента массива</param>
/// <param name="max">маскимальное значение элемента массива</param>
/// <returns>возварт двумерного массива</returns>
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

int[,] matrix = GetArray(4, 3, 0, 10);
PrintArray(matrix);


/// <summary>
/// метод сортировки строк двумерного массива по убыванию
/// </summary>
/// <param name="matr">на вход - двумерный массив</param>
/// <returns>возвращается сортированный массив</returns>
int[,] ArrangeStringsOfArray(int[,] matr)
{
  for (int m = 0; m < matr.GetLength(1); m++) //создан цикл для пузырьковой сортировки, проходит столько раз, сколько колонк в двумерном массиве
  {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int j = 0; (j + 1) < matr.GetLength(1); j++)
      {
        if (matr[i, j] < matr[i, j + 1])
        {
          int temp = matr[i, j];
          matr[i, j] = matr[i, j + 1];
          matr[i, j + 1] = temp;
        }
      }
    }
  }
  return matr;
}
Console.WriteLine();
Console.WriteLine("Сортированный массив:");
PrintArray(ArrangeStringsOfArray(matrix));