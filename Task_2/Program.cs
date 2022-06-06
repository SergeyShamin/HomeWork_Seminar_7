/* Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве и возвращает значение этого элемента или же
указание, что этого элемента нет.
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

int n = ReadInt("Введите число N: ");
int m = ReadInt("Введите число M: ");

double[,] array = new double[n, m];

FillArray(array);

int ni = ReadInt("Введите индекс: ");
int mi = ReadInt("Введите индекс: ");

if (ni >= 0 && ni < n && mi >= 0 && mi < m)
{
    Console.WriteLine(array[ni, mi]);
}
else
{
    Console.WriteLine("Такого элемента нет");
}
