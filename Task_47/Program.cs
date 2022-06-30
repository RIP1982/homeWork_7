//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");

double[,] doubleNum = new double [m,n]; 
Random random = new Random();

for(int i = 0; i < doubleNum.GetLength(0); i++)
{
    for(int j = 0; j < doubleNum.GetLength(1); j++)
    {
        doubleNum[i,j] = random.NextDouble()*100;       
    }
}
PrintArray(doubleNum);

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}