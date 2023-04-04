// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");
double[,] array = new double[m, n];

int[,] arrayWhole = new int[m, n];
arrayWhole = TransformArray(array);

WriteArray(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double Arif = 0;
  for (int j = 0; j < m; j++)
  {
    Arif += arrayWhole[j, i];
  }
  Arif = Math.Round(Arif / m, 1);
  Console.WriteLine($"столбца № {i+1} {Arif}");
}

int[,] TransformArray (double[,] array)
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArray (int[,] arrayWhole)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}