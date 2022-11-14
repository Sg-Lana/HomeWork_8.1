//Задача 1: Задайте двумерный массив. 
//Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int [,] CreateMatrix(int lenRows, int lenColumns, int minLimit, int maxLimit) //задаем массив
{
        int [,] matrix = new int[lenRows, lenColumns];
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++) // генерация строк
        {
                for (int j = 0; j < matrix.GetLength(1); j++) // генерация столбцов
                {
                        matrix[i, j] = random.Next(minLimit, maxLimit); // задали вывод случайных, целых элементов массива
                }
        }
        return matrix; // вернули двумерный массив
}

void PrintMatrix(int[,] matrix) // вывод на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine(); // переход на следующую строку
    }
}

int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    return matrix;
}

void PrintSortMatrix(int[,] array) // вывод на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine(); // переход на следующую строку
    }
}

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int rows = Prompt ("введите количество строк - > ");
int columns = Prompt ("введите количество столбцов - > ");
int min = Prompt ("введите минимальное значение диапазона чисел - > ");
int max = Prompt ("ввелите максимальное значение диапазона чисел  - > ");

int[,] newMatrix = CreateMatrix(rows, columns, min, max); // задали размер двумерного массива и определили диапазон случайных чисел
PrintMatrix(newMatrix); // вывели масив на экран
System.Console.WriteLine($"элементы в каждой строки массива упорядочили по убыванию и получили - >");
SortMatrix (newMatrix);
PrintSortMatrix(newMatrix);
