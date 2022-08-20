// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// ввод входных условий задачи
int n = 4;
int temp = 1;
int i = 0;
int j = 0;

int[,] arraySpiral = new int[n, n]; // создание спирального массива
while (temp <= arraySpiral.GetLength(0) * arraySpiral.GetLength(1))
{
  arraySpiral[i, j] = temp;
  temp++;
  if (i <= j + 1 
        && i + j < arraySpiral.GetLength(1) - 1)
        j++;

  else if (i < j    
        && i + j >= arraySpiral.GetLength(0) - 1)
        i++;
  else if (i >= j 
        && i + j > arraySpiral.GetLength(1) - 1)
        j--;
  else
        i--;
}
PrintArray(arraySpiral);

void PrintArray (int[,] array) // метод печати массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}