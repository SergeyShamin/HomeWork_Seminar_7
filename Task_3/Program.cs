/* Задайте двумерный массив из целых чисел, найдите 
среднее арифметическое элементов в каждом столбце.
*/


int ReadInt(string str)
{
    Console.WriteLine(str);

    int number = int.Parse(Console.ReadLine());
    return number;
}

void FillArray(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = random.Next(100);
        }
    }
}

void PrintAvg(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);


    for (int i = 0; i < m; i++)
    {
        int sum = 0;

        for (int j = 0; j < n; j++)
        {
            sum = sum + arr[j,i];
        }

        Console.WriteLine($"Среднее арфиметическое в столбце {i + 1} = {sum / n}");
    }
}

int n = ReadInt("Введите число N: ");
int m = ReadInt("Введите число M: ");

int[,] array = new int[n, m];

FillArray(array);
PrintAvg(array);