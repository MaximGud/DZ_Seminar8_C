// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/// <summary>
/// Создание трехмерного массива
/// </summary>
/// <param name="rows">количество строк</param>
/// <param name="cols">количество колонок</param>
/// <param name="depth">глубина</param>
/// <returns>возвращает трехмерный массив</returns>
int[,,] GetArray(int rows, int cols, int depth)
{
  int[,,] array = new int[rows, cols, depth];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = new Random().Next(10, 100);
      }
    }
  }
  return array;
}

/// <summary>
/// печать трехмерного массива
/// </summary>
/// <param name="arr">трехмерный массив</param>
void PrintArray(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
      }
    }
    Console.WriteLine();
  }
}

int[,,] matrix = GetArray(2, 2, 2);
PrintArray(matrix);