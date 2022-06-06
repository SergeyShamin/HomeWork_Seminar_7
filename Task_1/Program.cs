/* Задайте двумерный массив размеров m x n, заполненный 
случайными вещественными числами.
*/ 

int ReadInt(string str)
{
    Console.WriteLine(str);

    int number = int.Parse(Console.ReadLine());
    return number;
}

void FillArray(double[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = random.NextDouble() * 10;
        }
    }
}

void PrintArray(double[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);



    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(arr[i, j] + " ");
        }

        Console.WriteLine();
    }
}

int n = ReadInt("Введите число N: ");
int m = ReadInt("Введите число M: ");

double[,] array = new double[n, m];

FillArray(array);
PrintArray(array);