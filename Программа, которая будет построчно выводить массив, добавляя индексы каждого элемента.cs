//12(0,0,0) 22(0,0,1)

//45(1,0,0) 53(1,0,1)

// задание для входных параметров задачи
Console.WriteLine("Количество листов: ");
int lists = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

// задание диапазонов в соотвествии с примером задачи
int minRandom = 12;
int maxRandom = 99;

int[,,] matrix = GetMatrix(rows, columns, lists, minRandom, maxRandom); // создание матрицы
PrintIndexMatrix(matrix);
Console.WriteLine();

int[,,] GetMatrix(int row, int colmn, int list, int min, int max) // метод создания матрицы
{
    int[,,] array = new int[lists, rows, columns];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (minRandom<=maxRandom)
                {
                    array[i, j, k] = minRandom;
                    minRandom++;
                }
                else
                {
                   Console.WriteLine("Программа не расчичитана на генерацию массивов с числами больше 99");
                }
            }
        }
    }
    return array;
}

void PrintIndexMatrix(int[,,] array) // метод печати идексов матрицы
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine((i ++));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}