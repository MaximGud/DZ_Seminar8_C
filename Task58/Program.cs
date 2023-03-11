// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

/// <summary>
/// метод прозведения двух матриц
/// </summary>
/// <param name="matr1">матрица 1</param>
/// <param name="matr2">матрица 2</param>
/// <returns>возврат произведения матриц</returns>
int[,] MultipleMatrix(int[,] matr1, int[,] matr2)
{
  int[,] newMatrix = new int[2, 2];

  newMatrix[0, 0] = matr1[0, 0] * matr2[0, 0] + matr1[0, 1] * matr1[1, 0];
  newMatrix[0, 1] = matr1[0, 0] * matr2[0, 1] + matr1[0, 1] * matr1[1, 1];
  newMatrix[1, 0] = matr1[1, 0] * matr2[0, 0] + matr1[1, 0] * matr1[1, 0];
  newMatrix[1, 1] = matr1[1, 0] * matr2[0, 1] + matr1[1, 1] * matr1[1, 1];

  return newMatrix;
}

int[,] matrix1 = GetArray(2, 2, 0, 10);
PrintArray(matrix1);

Console.WriteLine();
int[,] matrix2 = GetArray(2, 2, 0, 10);
PrintArray(matrix1);
Console.WriteLine("Произведение двух матриц:");
PrintArray(MultipleMatrix(matrix1, matrix2));
