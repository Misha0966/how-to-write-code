//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//и

//1 5 8 5

//4 9 4 2

//7 2 2 6

//2 3 4 7

//Их произведение будет равно следующему массиву:

//1 20 56 10

//20 81 8 6

//56 8 4 24

//10 6 24 49



// задание для входных параметров задачи
Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());
int[,] matrix = InitMatrix(m, n);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("И");
Console.WriteLine();

PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Их произведение будет равно следующему массиву:");
Console.WriteLine();
PrintMultiTables(matrix);
Console.WriteLine();

int[,] InitMatrix(int m, int n) // метод создания матрицы
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix) // метод печати многомерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void PrintMultiTables(int[,] matrix) // метод печати произведения двух матриц
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}