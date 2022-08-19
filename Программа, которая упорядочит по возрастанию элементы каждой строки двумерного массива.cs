//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//В итоге получается вот такой массив:

//1 2 4 7

//2 3 5 9

//2 4 4 8


// задание для входных параметров задачи
Console.Write("Введите количество строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
int[,] Array = Random2D_Array(r, c);
Console.WriteLine();
Console.Write("Неотсортированный массив: ");
Console.WriteLine();
Print2DArray(Array);
int[,] NewArray = SortAscending(Array);
Console.WriteLine();
Console.Write("Отсортированный массив: ");
Console.WriteLine();
Print2DArray(NewArray);

int[,] Random2D_Array(int m, int n) // метод создания двумерного массива
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10); // указание диапозона элементов массива в соответствии с примером задачи
        }
    }
    return array;
}
int[,] SortAscending(int[,] array) // метод сортировки по возрастанию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}
void Print2DArray(int[,] NewArray) // метод печати двумерного массива
{
    Console.WriteLine();
    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            Console.Write(NewArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}