//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");
int[,] numbers = new int[m,n];

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i,j] = new Random().Next(-100, 100);
    }
}

PrintArray(numbers);

for(int j = 0; j < numbers.GetLength(1); j++)
    {
        double temp = 0;
        for(int i = 0; i < numbers.GetLength(0); i++)
            {
                temp = temp + numbers[i,j];
            }
            Console.WriteLine($"Average by column {j} = {Math.Round((temp / numbers.GetLength(0)), 2)}"); 
    }   
     
void PrintArray(int[,] array)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
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