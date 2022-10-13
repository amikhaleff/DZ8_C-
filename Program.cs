Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Введите номер порядковый номер задачи ");
Console.ForegroundColor = ConsoleColor.White;
int Task = int.Parse(Console.ReadLine() ?? "0");

if (Task == 1) ZADACHA_54();
else if (Task == 2) ZADACHA_56();
else if (Task == 3) ZADACHA_58();
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Такой задачи нет в списке!!!");
    Console.ResetColor();
}
void ZADACHA_54()
{
    Console.Clear();
    Console.WriteLine($" Задача 54: Задайте двумерный массив. \n Напишите программу, которая упорядочит по убыванию \n элементы каждой строки двумерного массива.");
    System.Console.WriteLine();


    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void GetArray(double[,] matrix, double min, double max)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
            }
        }
    }


    void PrintArray(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write("{0,7}", matr[i, j]);
            }
            Console.WriteLine();
        }
    }
    void SortedArrayRows(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        (array[i, k], array[i, k + 1]) =
                        (array[i, k + 1], array[i, k]);
                    }
                }
            }
        }
    }
    int m = ReadData("Введите количество строк m: ");
    int n = ReadData("Введите количество столбцов n: ");
    double min = ReadData("Введите min: ");
    double max = ReadData("Введите max: ");
    double[,] matrix = new double[m, n];
    Console.WriteLine();
    GetArray(matrix, min, max);
    PrintArray(matrix);
    SortedArrayRows(matrix);
    Console.ForegroundColor = ConsoleColor.Blue;
    System.Console.WriteLine($"В массиве стороки сортированы по убыванию :");
    PrintArray(matrix);
    System.Console.WriteLine();
}

void ZADACHA_56()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Задача 56: \n Задайте прямоугольный двумерный массив. \n Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.ResetColor();

    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void GetArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(-10, 10);
            }
        }
    }

    void FindSumOfRows(int[,] matrix)
    {
        int minSumOfRow = 0;
        int min_i = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sumOfRow = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
                sumOfRow += matrix[i, j];

            if (sumOfRow < minSumOfRow)
            {
                min_i = i;
                minSumOfRow = sumOfRow;
            }
            System.Console.WriteLine();
            Console.WriteLine($"Сумма строки:{i + 1} = {sumOfRow}");




        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Минимальная сумма в {min_i+1}-й строке и равна {minSumOfRow}");
    }


    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write("{0,5}", matr[i, j]);
            }
            Console.WriteLine();
        }
    }


    int m = ReadData("Введите количество строк m: ");
    int n = ReadData("Введите количество столбцов n: ");
    int[,] matrix = new int[m, n];
    GetArray(matrix);
    PrintArray(matrix);
    FindSumOfRows(matrix);


}

void ZADACHA_58()
{
    Console.Clear();

    int ReadData(string msg)// получение данных пользователя
    {
        Console.Write(msg);
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
    }

    void GetArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(-10, 10);
            }
        }
    }

    void MultiplicationOfMatrix(int[,] firstMatrix,
                                int[,] secondMatrix,
                                int[,] multiMatrix,
                                int m, int s)
    { if (m!=s) 
    {
        System.Console.WriteLine(" \nУмножение невозможно! \n Число строк первой матрицы должно совпадать \n с количеством столбцов второй матрицы!" );
        return;
    }
        for (int i = 0; i < multiMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiMatrix.GetLength(1); j++)
            {
                int sum=0;
                for (int k = 0; k < multiMatrix.GetLength(1); k++)
                {
                    sum+=firstMatrix[i,k]*secondMatrix[k,j];
                }
                multiMatrix[i,j]=sum;
            } 
        }

         
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write("{0,5}", matr[i, j]);
            }
            Console.WriteLine();
        }
    }


    int m = ReadData("Введите количество строк первой матрицы m: ");
    int n = ReadData("Введите количество столбцов первой матрицы n: ");
    int r = ReadData("Введите количество столбцов второй матрицы r: ");
    int s = ReadData("Введите количество столбцов второй матрицы s: ");
    int[,] firstMatrix = new int[m, n];
    int[,] secondMatrix= new int[r,s];
    int[,] multiMatrix= new int[m,s];
    Console.WriteLine();
    GetArray(firstMatrix);
    PrintArray(firstMatrix);
    System.Console.WriteLine();
    GetArray(secondMatrix);
    PrintArray(secondMatrix);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    MultiplicationOfMatrix(firstMatrix, secondMatrix, multiMatrix,m,s);
    System.Console.WriteLine("\tРезультат произведений двух матриц :");
    PrintArray(multiMatrix);
    Console.ResetColor();
    System.Console.WriteLine();
}
